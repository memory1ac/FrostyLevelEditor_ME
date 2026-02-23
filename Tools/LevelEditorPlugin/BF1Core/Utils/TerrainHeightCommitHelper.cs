using Frosty.Core;
using FrostySdk;
using FrostySdk.IO;
using FrostySdk.Managers.Entries;
using LevelEditorPlugin.Entities;
using LevelEditorPlugin.Resources;
using System;
using System.Collections.Generic;
using System.IO;

namespace LevelEditorPlugin.BF1Core.Utils;

/// <summary>
/// Precisely write terrain vertex edits from current session (in-memory modifications) back to Heightfield data + corresponding chunks.
/// First version only writes back non-persistent nodes (height data from chunks); persistent nodes still use original res.
/// </summary>
public static class TerrainHeightCommitHelper
{
    public static void CommitPendingEdits(TerrainEntity terrainEntity)
    {
        var edits = TerrainEditState.PendingEdits;
        if (terrainEntity == null || edits.Count == 0)
        {
            App.Logger.Log("No pending terrain vertex modifications to write back");
            return;
        }

        var data = terrainEntity.Terrain.Data;
        ResAssetEntry resEntry = App.AssetManager.GetResEntry(data.TerrainStreamingTreeResource);
        if (resEntry == null)
        {
            App.Logger.LogError("TerrainStreamingTree Res not found; cannot write back terrain height");
            return;
        }

        TerrainStreamingTree tree = App.AssetManager.GetResAs<TerrainStreamingTree>(resEntry);
        if (tree == null)
        {
            App.Logger.LogError("Unable to load TerrainStreamingTree; cannot write back terrain height");
            return;
        }

        HeightfieldTree htree = tree.GetRasterTree(RasterTreeTypes.HeightfieldTreeType) as HeightfieldTree;
        if (htree == null)
        {
            App.Logger.LogError("TerrainStreamingTree has no HeightfieldTree; cannot write back terrain height");
            return;
        }

        // 1) Build mapping for non-persistent nodes (chunk height data)
        var nodeToChunkMap = BuildNodeToChunkOffsetMap(tree, htree);

        // 2) Build mapping for persistent nodes (res embedded height data)
        byte[] resBytes = GetResBytes(resEntry);
        if (resBytes == null || resBytes.Length == 0)
        {
            App.Logger.LogError("Unable to read TerrainStreamingTree Res data; cannot write back persistent node height");
            return;
        }
        var persistentNodeToResOffset = BuildPersistentNodeToResOffsetMap(resBytes, htree);

        // Group all pending modifications by chunk / Res
        var editsByChunk = new Dictionary<Guid, List<(int OffsetBytes, ushort HeightValue)>>();
        var editsInRes = new List<(int OffsetBytes, ushort HeightValue)>();

        float worldSizeY = htree.worldSizeY;
        if (worldSizeY <= 0.0f)
        {
            App.Logger.LogError("HeightfieldTree.worldSizeY invalid; cannot convert world height");
            return;
        }

        float terrainTransformY = terrainEntity.GetTransform().TranslationVector.Y;

        // Compute baseLocalY / rangeLocalY for height conversion (using root node bounding box)
        float baseLocalY = 0.0f;
        float rangeLocalY = worldSizeY;
        if (htree.getRootNode() is HeightfieldTreeNode rootNode)
        {
            baseLocalY = rootNode.boundingBox.min.y;
            float bbRange = rootNode.boundingBox.max.y - rootNode.boundingBox.min.y;
            if (bbRange > 0.0001f)
                rangeLocalY = bbRange;
        }
        if (rangeLocalY <= 0.0f)
        {
            App.Logger.LogError("Terrain height range invalid; cannot convert world height");
            return;
        }

        foreach (var e in edits)
        {
            var key = (e.NodeIndexX, e.NodeIndexY, e.NodeLevel);

            int sampleIndex = e.SampleIndex;
            if (sampleIndex < 0)
                continue;

            // World height -> local height -> normalized -> ushort
            float targetLocalY = e.TargetWorldY - terrainTransformY;
            float heightNormalized = (targetLocalY - baseLocalY) / rangeLocalY;
            // .NET 4.8 doesn't have Math.Clamp, manually clamp here
            heightNormalized = Math.Max(0.0f, Math.Min(1.0f, heightNormalized));
            ushort flatValue = (ushort)(heightNormalized * 65535.0f);

            // Prioritize non-persistent nodes from chunks
            if (nodeToChunkMap.TryGetValue(key, out var mapInfo))
            {
                int byteOffset = mapInfo.BaseOffset + sampleIndex * 2;
                if (byteOffset < 0)
                    continue;

                if (!editsByChunk.TryGetValue(mapInfo.ChunkId, out var list))
                {
                    list = new List<(int, ushort)>();
                    editsByChunk[mapInfo.ChunkId] = list;
                }

                list.Add((byteOffset, flatValue));
                continue;
            }

            // For persistent nodes, write back to Res embedded Heightfield data
            if (persistentNodeToResOffset.TryGetValue(key, out int resBaseOffset))
            {
                int byteOffset = resBaseOffset + sampleIndex * 2;
                if (byteOffset < 0)
                    continue;

                editsInRes.Add((byteOffset, flatValue));
            }
        }

        // First write back persistent node heights in Res
        if (editsInRes.Count > 0)
        {
            foreach (var (offset, value) in editsInRes)
            {
                if (offset + 1 >= resBytes.Length)
                    continue;

                resBytes[offset + 0] = (byte)(value & 0xFF);
                resBytes[offset + 1] = (byte)((value >> 8) & 0xFF);
            }

            App.AssetManager.ModifyRes(resEntry.ResRid, resBytes, resEntry.ResMeta);
        }

        // Then read and write back non-persistent nodes per chunk
        int modifiedChunks = 0;
        foreach (var kv in editsByChunk)
        {
            Guid chunkId = kv.Key;
            var modifications = kv.Value;

            ChunkAssetEntry chunkEntry = App.AssetManager.GetChunkEntry(chunkId);
            if (chunkEntry == null)
                continue;

            byte[] chunkBytes = GetChunkBytes(chunkEntry);
            if (chunkBytes == null || chunkBytes.Length == 0)
                continue;

            foreach (var (offset, value) in modifications)
            {
                if (offset + 1 >= chunkBytes.Length)
                    continue;

                chunkBytes[offset + 0] = (byte)(value & 0xFF);
                chunkBytes[offset + 1] = (byte)((value >> 8) & 0xFF);
            }

            if (App.AssetManager.ModifyChunk(chunkId, chunkBytes))
                modifiedChunks++;
        }

        App.Logger.Log($"Terrain vertex edits written to {editsInRes.Count} height data locations in Res and {modifiedChunks} chunks updated.");

        // Clear pending list to avoid duplicate writes
        TerrainEditState.ClearEdits();
    }

    /// <summary>
    /// Build NodeId -> (ChunkId, BaseOffset) mapping for all non-persistent Heightfield nodes.
    /// BaseOffset is the starting byte offset of this node's height data in the chunk.
    /// </summary>
    private static Dictionary<(ushort X, ushort Y, byte Level), (Guid ChunkId, int BaseOffset)> BuildNodeToChunkOffsetMap(TerrainStreamingTree tree, HeightfieldTree htree)
    {
        var map = new Dictionary<(ushort, ushort, byte), (Guid, int)>();

        int dataSize = htree.DataSize;

        foreach (RasterTreeNode rnode in htree.nodes)
        {
            if (rnode is not HeightfieldTreeNode node)
                continue;

            if (!node.hasData || node.hasPersistentData)
                continue; // Only care about data from chunks

            var id = node.id;
            var key = (id.indexX, id.indexY, id.level);

            TerrainStreamingTreeNode snode = tree.GetNode(id);
            if (snode != null && snode.lod0Id != Guid.Empty)
            {
                // Normal lod0: height data at start of single block
                map[key] = (snode.lod0Id, 0);
                continue;
            }

            // hi-res case: height data from parent's lod1Guid, 4 child nodes share same chunk
            if (node.parent == null)
                continue;

            TerrainStreamingTreeNode parentSnode = tree.GetNode(node.parent.id);
            if (parentSnode == null || parentSnode.lod1Guid == Guid.Empty)
                continue;

            int childIndex = node.parent.children.IndexOf(node);
            if (childIndex < 0 || childIndex > 3)
                continue;

            // Read order is parent.children[3], [2], [1], [0], corresponding to blockIndex = 0,1,2,3
            int blockIndex = 3 - childIndex;
            int baseOffset = blockIndex * dataSize;

            map[key] = (parentSnode.lod1Guid, baseOffset);
        }

        return map;
    }

    /// <summary>
    /// Build NodeId -> Res height data start offset (bytes) for all persistent Heightfield nodes.
    /// Parsing logic is equivalent to HeightfieldTree.loadAndInitialize/loadNodes, but only records offsets.
    /// </summary>
    private static Dictionary<(ushort X, ushort Y, byte Level), int> BuildPersistentNodeToResOffsetMap(byte[] resBytes, HeightfieldTree htree)
    {
        var map = new Dictionary<(ushort, ushort, byte), int>();

        try
        {
            using (var stream = new MemoryStream(resBytes, false))
            using (var reader = new NativeReader(stream))
            {
                // === TerrainStreamingTree header, matches TerrainStreamingTree.Read ===
                reader.ReadUInt();   // unblurredSamplesPerNodeSidePot
                reader.ReadBoolean(); // trackTextureDetailFalloff
                reader.ReadFloat();   // invisibleDetailReductionFactor
                reader.ReadFloat();   // occludedDetailReductionFactor
                reader.ReadUInt();    // resourceBlurriness
                reader.ReadUInt();    // unknown
                uint nodeCountStreaming = reader.ReadUInt();
                reader.ReadBoolean(); // freeStreamingEnabled

                // Placeholder for rasterTrees
                for (int i = 0; i < (int)RasterTreeTypes.RasterTreeTypeCount; i++) { }

                byte rasterTreeType = reader.ReadByte();
                while (rasterTreeType != 0xFF)
                {
                    uint rasterTreeLoadSize = reader.ReadUInt();
                    long startPos = reader.Position;

                    if (rasterTreeType == (byte)RasterTreeTypes.HeightfieldTreeType)
                    {
                        // Parse HeightfieldTree block, record persistent node offset
                        CollectPersistentOffsetsInHeightfieldBlock(reader, startPos, rasterTreeLoadSize, htree, map);
                        break;
                    }

                    reader.Position = startPos + rasterTreeLoadSize;
                    rasterTreeType = reader.ReadByte();
                }
            }
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Failed to parse Heightfield persistent node offsets in Res: {ex.Message}");
        }

        return map;
    }

    private static void CollectPersistentOffsetsInHeightfieldBlock(NativeReader reader, long blockStart, uint blockSize, HeightfieldTree htree, Dictionary<(ushort, ushort, byte), int> map)
    {
        // === Corresponds to HeightfieldTree.loadAndInitialize ===
        uint nodeSamplesPerSide = reader.ReadUInt();
        reader.ReadUInt(); // resourceAtlasSampleCountX
        reader.ReadUInt(); // resourceAtlasSampleCountY
        int blurriness = reader.ReadInt();
        float worldSizeY = reader.ReadFloat();

        float physicsMetersPerSample = reader.ReadFloat();
        int physicsCropWidth = reader.ReadInt();

        bool unknown1 = reader.ReadBoolean();
        float unknown2 = reader.ReadFloat();
        uint minMaxStackDepth = reader.ReadUInt();
        uint occluderGridStackDepth = reader.ReadUInt();
        uint unknown5 = reader.ReadUInt();
        reader.ReadUInt(); // unknown6
        reader.ReadUInt(); // unknown7
        reader.ReadFloat(); // unknown8

        // Compute minMaxStackSize / occluderGridStackSize, matches HeightfieldTree
        uint minMaxStackSize = 0;
        {
            uint tmp = (uint)(1 << (int)(minMaxStackDepth - 1));
            int cnt = 0;
            do
            {
                uint b = (uint)((long)tmp >> cnt++);
                minMaxStackSize += 2 * b * b;
            } while (cnt < minMaxStackDepth);
        }

        uint occluderGridStackSize = 0;
        {
            uint tmp = (uint)(1 << (int)(occluderGridStackDepth - 1));
            int cnt = 0;
            do
            {
                uint b = (uint)((int)tmp >> cnt++);
                occluderGridStackSize += (b + 1) * (b + 1);
            } while (cnt < occluderGridStackDepth);
        }

        uint nodeCount;
        uint persistentNodeCount;
#if BFN
        nodeCount = reader.ReadUInt(Endian.Big);
        persistentNodeCount = reader.ReadUInt(Endian.Big);
#else
        nodeCount = reader.ReadUInt();
        persistentNodeCount = reader.ReadUInt();
#endif

        reader.ReadUInt(); // unknown9
        reader.ReadUInt(); // unknown10
        reader.ReadUInt(); // unknown11

        // Total size of height block
        int dataSize = htree.DataSize;

        // Recursively traverse nodes, record persistent node height data start offsets
        QuadTreeNodeId rootId = new QuadTreeNodeId();
        int id = 0;
        int index = 1;
        LoadNodesPersistentOffsets(reader, id, ref index, rootId, nodeCount, minMaxStackSize, dataSize, map);
    }

    private static void LoadNodesPersistentOffsets(NativeReader reader, int id, ref int index, QuadTreeNodeId nodeId, uint nodeCount, uint minMaxStackSize, int dataSize, Dictionary<(ushort, ushort, byte), int> map)
    {
        if (id >= nodeCount)
            return;

        // Corresponds to read order in HeightfieldTree.loadNodes
        reader.ReadFloat(); // bb.min.x
        reader.ReadFloat(); // bb.min.y
        reader.ReadFloat(); // bb.min.z
        reader.ReadFloat(); // bb.max.x
        reader.ReadFloat(); // bb.max.y
        reader.ReadFloat(); // bb.max.z

        if (ProfilesLibrary.DataVersion == 20170321 || ProfilesLibrary.DataVersion == 20171110)
            reader.ReadFloat(); // unknown1

        bool nodeDisabled = reader.ReadBoolean();
        if (nodeDisabled)
            return;

        bool nodeHasBeenPruned = reader.ReadBoolean();
        bool nodeHasData = reader.ReadBoolean();
        bool nodeUnknown = reader.ReadBoolean();
        bool nodePersistent = reader.ReadBoolean();

        if (nodeHasBeenPruned)
            reader.ReadBytes((int)(minMaxStackSize * 2)); // unknownBytes1

        if (nodeHasData && nodePersistent)
        {
            // This is where loadData starts: heightBytes first, then stack, then occluder, then unknown5*unknown5
            int pos = (int)reader.Position;
            map[(nodeId.indexX, nodeId.indexY, nodeId.level)] = pos;

            // Skip entire DataSize (matches HeightfieldTree.loadData)
            reader.Position = pos + dataSize;
        }

        bool nodeHasChildren = reader.ReadBoolean();
        if (nodeHasChildren)
        {
            int firstChildIndex = index;
            index += 4;

            QuadTreeNodeId childNodeId = new QuadTreeNodeId
            {
                level = (byte)(nodeId.level + 1)
            };

            for (int i = 0; i < 4; i++)
            {
                childNodeId.indexX = (ushort)(QuadTreeNodeId.quadtreeNodeChildOffsetX[i] + 2 * nodeId.indexX);
                childNodeId.indexY = (ushort)(QuadTreeNodeId.quadtreeNodeChildOffsetY[i] + 2 * nodeId.indexY);

                LoadNodesPersistentOffsets(reader, firstChildIndex + i, ref index, childNodeId, nodeCount, minMaxStackSize, dataSize, map);
            }
        }
    }

    private static byte[] GetChunkBytes(ChunkAssetEntry entry)
    {
        try
        {
            using (Stream s = App.AssetManager.GetChunk(entry))
            {
                if (s == null) return null;
                using (var ms = new MemoryStream())
                {
                    s.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Failed to read Chunk: {ex.Message}");
            return null;
        }
    }

    private static byte[] GetResBytes(ResAssetEntry entry)
    {
        try
        {
            using (Stream s = App.AssetManager.GetRes(entry))
            {
                if (s == null) return null;
                using (var ms = new MemoryStream())
                {
                    s.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Failed to read Res: {ex.Message}");
            return null;
        }
    }
}


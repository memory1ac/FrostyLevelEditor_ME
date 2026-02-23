using Frosty.Core;
using FrostySdk;
using FrostySdk.IO;
using FrostySdk.Managers.Entries;
using LevelEditorPlugin.Resources;
using SharpDX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LevelEditorPlugin.BF1Core.Utils;

/// <summary>
/// One-click flatten terrain: modify persistent height data embedded in TerrainStreamingTree res and height data in all terrain chunks.
/// Does not refresh viewport; user must manually reopen map to view changes.
/// </summary>
public static class TerrainFlattenHelper
{
    /// <summary>
    /// Execute super flat on current level terrain: write back to res and chunk, no viewport update.
    /// </summary>
    /// <param name="terrainEntity">Terrain entity of current level</param>
    /// <param name="worldHeightY">Target world height Y (same units as scene coordinates); clamped to [0, worldSizeY] and converted to internal terrain height</param>
    /// <returns>True if successful; false if no writable terrain</returns>
    public static bool FlattenTerrain(Entities.TerrainEntity terrainEntity, float worldHeightY = 0.0f)
    {
        if (terrainEntity?.Terrain?.Data == null)
            return false;

        var data = terrainEntity.Terrain.Data;
        ResAssetEntry resEntry = App.AssetManager.GetResEntry(data.TerrainStreamingTreeResource);
        if (resEntry == null)
        {
            App.Logger.LogError("TerrainStreamingTree Res not found");
            return false;
        }

        // Get in-memory tree structure (for DataSize, heightBytes, streaming nodes and chunk id)
        TerrainStreamingTree tree = App.AssetManager.GetResAs<TerrainStreamingTree>(resEntry);
        if (tree == null)
        {
            App.Logger.LogError("Unable to load TerrainStreamingTree");
            return false;
        }

        HeightfieldTree htree = tree.GetRasterTree(RasterTreeTypes.HeightfieldTreeType) as HeightfieldTree;
        if (htree == null)
        {
            App.Logger.LogError("TerrainStreamingTree has no HeightfieldTree");
            return false;
        }

        int heightBytesPerNode = (int)((2 * htree.nodeSamplesPerSide) * htree.nodeSamplesPerSide);
        int dataSize = htree.DataSize;

        float worldSizeY = htree.worldSizeY;
        if (worldSizeY <= 0.0f)
        {
            App.Logger.LogError("HeightfieldTree.worldSizeY invalid; cannot convert world height");
            return false;
        }

        // 目标世界高度 -> 目标“局部高度”(扣除 TerrainEntity Transform) -> 归一化 -> ushort
        // 注意：地形顶点高度是局部空间，最终会叠加 TerrainEntity 的 Transform（RenderProxy 的 instance transform）。
        float terrainTransformY = terrainEntity.GetTransform().TranslationVector.Y;
        float targetLocalY = worldHeightY - terrainTransformY;

        float baseLocalY = 0.0f;
        float rangeLocalY = worldSizeY;

        // Some maps have a base(minY) offset in game-side height conversion; HeightfieldTreeNode boundingBox.min.y/max.y provides this range info.
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
            return false;
        }

        float heightNormalized = (targetLocalY - baseLocalY) / rangeLocalY;
        heightNormalized = Math.Max(0f, Math.Min(1f, heightNormalized));
        ushort flatValue = (ushort)(heightNormalized * 65535f);

        // 1) 修改 Res：解析出所有“持久高度块”在 res 中的偏移，替换为统一高度
        byte[] resBytes = GetResBytes(resEntry);
        if (resBytes == null || resBytes.Length == 0)
        {
            App.Logger.LogError("Unable to read TerrainStreamingTree Res data");
            return false;
        }

        List<long> resHeightPositions = CollectHeightfieldDataPositionsInRes(resBytes, dataSize, heightBytesPerNode);
        if (resHeightPositions == null)
        {
            App.Logger.LogError("Error parsing TerrainStreamingTree Res");
            return false;
        }

        foreach (long pos in resHeightPositions)
            FlattenHeightBlock(resBytes, (int)pos, heightBytesPerNode, flatValue);

        App.AssetManager.ModifyRes(resEntry.ResRid, resBytes, resEntry.ResMeta);
        App.Logger.Log(
            $"Wrote TerrainStreamingTree Res, total {resHeightPositions.Count} persistent height blocks (" +
            $"worldHeightY={worldHeightY:0.#####}, terrainTransformY={terrainTransformY:0.#####}, " +
            $"targetLocalY={targetLocalY:0.#####}, baseLocalY={baseLocalY:0.#####}, rangeLocalY={rangeLocalY:0.#####}, " +
            $"worldSizeY={worldSizeY:0.#####}, norm={heightNormalized:0.#####}）");

        // 2) Modify all terrain Chunks
        HashSet<Guid> chunkIds = CollectTerrainChunkIds(tree);
        int chunkCount = 0;
        foreach (Guid chunkId in chunkIds)
        {
            ChunkAssetEntry chunkEntry = App.AssetManager.GetChunkEntry(chunkId);
            if (chunkEntry == null) continue;

            byte[] chunkBytes = GetChunkBytes(chunkEntry);
            if (chunkBytes == null || chunkBytes.Length == 0) continue;

            // Chunk contains contiguous blocks, each dataSize in size; first heightBytesPerNode of each block is height
            int blockCount = chunkBytes.Length / dataSize;
            for (int i = 0; i < blockCount; i++)
            {
                int offset = i * dataSize;
                if (offset + heightBytesPerNode <= chunkBytes.Length)
                    FlattenHeightBlock(chunkBytes, offset, heightBytesPerNode, flatValue);
            }

            if (App.AssetManager.ModifyChunk(chunkId, chunkBytes))
                chunkCount++;
        }

        App.Logger.Log($"Wrote {chunkCount} terrain Chunks");
        return true;
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

    /// <summary>
    /// Set all height data (ushort array) in a block to the same value
    /// </summary>
    private static void FlattenHeightBlock(byte[] buffer, int startOffset, int heightBytesCount, ushort value)
    {
        for (int i = 0; i < heightBytesCount; i += 2)
        {
            if (startOffset + i + 2 <= buffer.Length)
            {
                buffer[startOffset + i] = (byte)(value & 0xFF);
                buffer[startOffset + i + 1] = (byte)((value >> 8) & 0xFF);
            }
        }
    }

    /// <summary>
    /// 从 res 二进制中解析出 HeightfieldTree 里所有“持久节点”高度块在 res 中的起始位置。
    /// 解析逻辑与 TerrainStreamingTree.Read + HeightfieldTree.loadAndInitialize/loadNodes 一致。
    /// </summary>
    private static List<long> CollectHeightfieldDataPositionsInRes(byte[] resBytes, int dataSize, int heightBytesPerNode)
    {
        var positions = new List<long>();
        try
        {
            using (var stream = new MemoryStream(resBytes, false))
            using (var reader = new NativeReader(stream))
            {
                // TerrainStreamingTree header
                reader.ReadUInt();
                reader.ReadBoolean();
                reader.ReadFloat();
                reader.ReadFloat();
                reader.ReadUInt();
                reader.ReadUInt();
                uint nodeCount = reader.ReadUInt();
                reader.ReadBoolean();

                for (int i = 0; i < (int)RasterTreeTypes.RasterTreeTypeCount; i++) { }

                byte rasterTreeType = reader.ReadByte();
                while (rasterTreeType != 0xFF)
                {
                    uint rasterTreeLoadSize = reader.ReadUInt();
                    long startPos = reader.Position;

                    if (rasterTreeType == (byte)RasterTreeTypes.HeightfieldTreeType)
                    {
                        CollectHeightfieldPositionsInBlock(reader, startPos, rasterTreeLoadSize, dataSize, heightBytesPerNode, positions);
                        break;
                    }

                    reader.Position = startPos + rasterTreeLoadSize;
                    rasterTreeType = reader.ReadByte();
                }
            }
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Failed to parse Res height block positions: {ex.Message}");
            return null;
        }

        return positions;
    }

    /// <summary>
    /// Advance reader within HeightfieldTree block by loadAndInitialize + loadNodes order, record all persistent height block start positions.
    /// </summary>
    private static void CollectHeightfieldPositionsInBlock(NativeReader reader, long blockStart, uint blockSize, int dataSize, int heightBytesPerNode, List<long> positions)
    {
        // loadAndInitialize: exactly matches HeightfieldTree
        reader.ReadUInt();   // nodeSamplesPerSide
        reader.ReadUInt();
        reader.ReadUInt();
        reader.ReadInt();    // blurriness
        reader.ReadFloat();  // worldSizeY
        reader.ReadFloat();
        reader.ReadInt();
        reader.ReadBoolean();
        reader.ReadFloat();
        uint minMaxStackDepth = reader.ReadUInt();
        uint occluderGridStackDepth = reader.ReadUInt();
        reader.ReadUInt();   // unknown5
        reader.ReadUInt();
        reader.ReadUInt();
        reader.ReadFloat();

        uint minMaxStackSize = ComputeMinMaxStackSize(minMaxStackDepth);
        uint occluderGridStackSize = ComputeOccluderGridStackSize(occluderGridStackDepth);

#if BFN
        uint nodeCount = reader.ReadUInt(Endian.Big);
        reader.ReadUInt(Endian.Big);
#else
        uint nodeCount = reader.ReadUInt();
        reader.ReadUInt();
#endif
        reader.ReadUInt();
        reader.ReadUInt();
        reader.ReadUInt();

        // Recursive loadNodes, only advance stream and record persistent height block positions
        int id = 0;
        int index = 1;
        LoadNodesCollectPositions(reader, id, ref index, nodeCount, dataSize, heightBytesPerNode, (int)minMaxStackSize * 2, positions);
    }

    private static void LoadNodesCollectPositions(NativeReader reader, int id, ref int index, uint nodeCount, int dataSize, int heightBytesPerNode, int minMaxPrunedBytes, List<long> positions)
    {
        if (id >= nodeCount) return;

        reader.ReadFloat();
        reader.ReadFloat();
        reader.ReadFloat();
        reader.ReadFloat();
        reader.ReadFloat();
        reader.ReadFloat();

        if (ProfilesLibrary.DataVersion == 20170321 || ProfilesLibrary.DataVersion == 20171110)
            reader.ReadFloat();

        bool nodeDisabled = reader.ReadBoolean();
        if (nodeDisabled) return;

        bool nodeHasBeenPruned = reader.ReadBoolean();
        bool nodeHasData = reader.ReadBoolean();
        reader.ReadBoolean(); // nodeUnknown
        bool nodePersistent = reader.ReadBoolean();

        if (nodeHasBeenPruned)
            reader.ReadBytes(minMaxPrunedBytes);

        if (nodeHasData && nodePersistent)
        {
            long pos = reader.Position;
            positions.Add(pos);
            reader.Position = pos + dataSize;
        }

        bool nodeHasChildren = reader.ReadBoolean();
        if (nodeHasChildren)
        {
            int firstChildIndex = index;
            index += 4;
            for (int i = 0; i < 4; i++)
                LoadNodesCollectPositions(reader, firstChildIndex + i, ref index, nodeCount, dataSize, heightBytesPerNode, minMaxPrunedBytes, positions);
        }
    }

    private static uint ComputeMinMaxStackSize(uint minMaxStackDepth)
    {
        uint tmp = (uint)(1 << (int)(minMaxStackDepth - 1));
        int cnt = 0;
        uint minMaxStackSize = 0;
        do
        {
            uint b = (uint)((long)tmp >> cnt++);
            minMaxStackSize += 2 * b * b;
        } while (cnt < minMaxStackDepth);
        return minMaxStackSize;
    }

    private static uint ComputeOccluderGridStackSize(uint occluderGridStackDepth)
    {
        uint tmp = (uint)(1 << (int)(occluderGridStackDepth - 1));
        int cnt = 0;
        uint occluderGridStackSize = 0;
        do
        {
            uint b = (uint)((int)tmp >> cnt++);
            occluderGridStackSize += (b + 1) * (b + 1);
        } while (cnt < occluderGridStackDepth);
        return occluderGridStackSize;
    }

    /// <summary>
    /// Collect all Chunk Guids used by terrain (lod0Id + lod1Guid)
    /// </summary>
    private static HashSet<Guid> CollectTerrainChunkIds(TerrainStreamingTree tree)
    {
        var set = new HashSet<Guid>();
        TerrainStreamingTreeNode root = tree.GetRootNode();
        if (root == null) return set;

        CollectChunkIdsRecursive(root, set);
        return set;
    }

    private static void CollectChunkIdsRecursive(TerrainStreamingTreeNode node, HashSet<Guid> set)
    {
        if (node == null) return;
        if (node.lod0Id != Guid.Empty)
            set.Add(node.lod0Id);
        if (node.lod1Guid != Guid.Empty)
            set.Add(node.lod1Guid);
        foreach (var child in node.children)
            CollectChunkIdsRecursive(child, set);
    }
}

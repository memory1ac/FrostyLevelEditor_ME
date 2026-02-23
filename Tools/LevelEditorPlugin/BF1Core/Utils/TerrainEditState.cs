using LevelEditorPlugin.Render;
using LevelEditorPlugin.Render.Proxies;
using LevelEditorPlugin.Resources;
using SharpDX;
using System.Collections.Generic;

namespace LevelEditorPlugin.BF1Core.Utils;

/// <summary>
/// Global state for terrain edit mode (whether enabled, currently selected terrain vertex, pending height edits to write back, etc.).
/// </summary>
public static class TerrainEditState
{
    /// <summary>
    /// Whether terrain edit mode is enabled.
    /// </summary>
    public static bool IsTerrainEditModeEnabled { get; set; }

    /// <summary>
    /// Currently selected terrain vertex (only used in terrain edit mode).
    /// </summary>
    public static TerrainVertexSelection? CurrentVertex { get; set; }

    /// <summary>
    /// Pending height edits to write back (based on Heightfield node Id + sample index + target world height).
    /// </summary>
    public static List<TerrainVertexEdit> PendingEdits { get; } = new List<TerrainVertexEdit>();

    public static void ClearSelection()
    {
        CurrentVertex = null;
    }

    public static void ClearEdits()
    {
        PendingEdits.Clear();
    }

    /// <summary>
    /// Add or update a pending height edit record (same node + sample index overwrites old value).
    /// </summary>
    public static void AddOrUpdateEdit(QuadTreeNodeId nodeId, int sampleIndex, float targetWorldY)
    {
        for (int i = 0; i < PendingEdits.Count; i++)
        {
            var e = PendingEdits[i];
            if (e.NodeIndexX == nodeId.indexX && e.NodeIndexY == nodeId.indexY && e.NodeLevel == nodeId.level && e.SampleIndex == sampleIndex)
            {
                e.TargetWorldY = targetWorldY;
                PendingEdits[i] = e;
                return;
            }
        }

        PendingEdits.Add(new TerrainVertexEdit
        {
            NodeIndexX = nodeId.indexX,
            NodeIndexY = nodeId.indexY,
            NodeLevel = nodeId.level,
            SampleIndex = sampleIndex,
            TargetWorldY = targetWorldY
        });
    }
}

/// <summary>
/// Result of a terrain vertex pick operation.
/// </summary>
public struct TerrainVertexSelection
{
    /// <summary>
    /// Associated render proxy (TerrainRenderProxy) for world transform, etc.
    /// </summary>
    public TerrainRenderProxy Proxy;

    /// <summary>
    /// Associated chunk renderable.
    /// </summary>
    public TerrainChunkRenderable Chunk;

    /// <summary>
    /// Index in chunk vertex array.
    /// </summary>
    public int VertexIndex;

    /// <summary>
    /// Vertex world position (for UI display).
    /// </summary>
    public Vector3 WorldPosition;
}

/// <summary>
/// Record of a vertex height edit pending write back.
/// </summary>
public struct TerrainVertexEdit
{
    public ushort NodeIndexX;
    public ushort NodeIndexY;
    public byte NodeLevel;

    public int SampleIndex;

    /// <summary>
    /// Target world height Y (converted to ushort when writing back).
    /// </summary>
    public float TargetWorldY;
}


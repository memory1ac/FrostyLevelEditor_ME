using LevelEditorPlugin.Render;
using LevelEditorPlugin.Render.Proxies;
using SharpDX;

namespace LevelEditorPlugin.BF1Core.Utils;

/// <summary>
/// Helper methods for picking terrain vertices from mouse ray.
/// </summary>
public static class TerrainVertexPicker
{
    /// <summary>
    /// Try to pick the vertex closest to the ray on the given TerrainRenderProxy.
    /// Only considered a hit when distance is below a certain threshold.
    /// </summary>
    public static bool TryPickVertex(Ray worldRay, TerrainRenderProxy proxy, out TerrainVertexSelection selection)
    {
        selection = default;

        TerrainChunkRenderable chunk = proxy.RenderData;
        if (chunk == null || chunk.TerrainVertices == null || chunk.TerrainVertices.Count == 0)
            return false;

        // Transform ray to chunk local space
        Matrix invWorld = Matrix.Invert(proxy.Transform);
        Ray localRay = new Ray(
            Vector3.TransformCoordinate(worldRay.Position, invWorld),
            Vector3.Normalize(Vector3.TransformNormal(worldRay.Direction, invWorld))
        );

        float bestDistSq = float.MaxValue;
        int bestIndex = -1;
        Vector3 bestLocalPos = default;

        for (int i = 0; i < chunk.TerrainVertices.Count; i++)
        {
            Vector3 p = chunk.TerrainVertices[i].Position; // Local space

            Vector3 v = p - localRay.Position;
            float t = Vector3.Dot(v, localRay.Direction);
            if (t < 0.0f)
                continue; // Behind ray

            Vector3 closest = localRay.Position + t * localRay.Direction;
            float distSq = (closest - p).LengthSquared();

            if (distSq < bestDistSq)
            {
                bestDistSq = distSq;
                bestIndex = i;
                bestLocalPos = p;
            }
        }

        // Threshold can be adjusted based on terrain resolution; using a conservative value here
        const float MaxPickDistanceSq = 4.0f; // ~2 units distance

        if (bestIndex >= 0 && bestDistSq <= MaxPickDistanceSq)
        {
            Vector3 worldPos = Vector3.TransformCoordinate(bestLocalPos, proxy.Transform);
            selection = new TerrainVertexSelection
            {
                Proxy = proxy,
                Chunk = chunk,
                VertexIndex = bestIndex,
                WorldPosition = worldPos
            };
            return true;
        }

        return false;
    }

    /// <summary>
    /// Derive corresponding Heightfield sample index from vertex index and dim of TerrainChunkRenderable.
    /// Logic matches the loop order (ny, nx, y, x) when constructing vertices.
    /// </summary>
    public static int GetSampleIndexForVertex(int vertexIndex, int dim)
    {
        if (dim <= 0)
            return -1;

        int tileDimVert = (dim / 4) + 1;           // Vertices per tile = (dim/4+1)^2
        int vertsPerTile = tileDimVert * tileDimVert;

        if (vertsPerTile <= 0)
            return -1;

        int tileIndex = vertexIndex / vertsPerTile;      // 0..15
        int vertexInTile = vertexIndex % vertsPerTile;

        int ny = tileIndex / 4;
        int nx = tileIndex % 4;

        int y = vertexInTile / tileDimVert;
        int x = vertexInTile % tileDimVert;

        int dim4 = dim / 4;

        int sampleY = ny * dim4 + y;
        int sampleX = nx * dim4 + x;

        // Safety check (allow slightly over one row/column; caller validates valid range)
        if (sampleY < 0 || sampleX < 0 || sampleY >= dim * 2 || sampleX >= dim)
            return -1;

        return sampleY * dim + sampleX;
    }
}


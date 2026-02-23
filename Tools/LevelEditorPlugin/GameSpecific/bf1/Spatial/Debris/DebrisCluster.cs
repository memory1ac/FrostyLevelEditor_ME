using Frosty.Core.Viewport;
using LevelEditorPlugin.Managers;
using LevelEditorPlugin.Render.Proxies;
using System.Collections.Generic;

namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebrisClusterData))]
public class DebrisCluster : GameComponentEntity, IEntityData<FrostySdk.Ebx.DebrisClusterData>
{
    public new FrostySdk.Ebx.DebrisClusterData Data => data as FrostySdk.Ebx.DebrisClusterData;
    public Assets.MeshAsset Mesh { get; private set; }

    public DebrisCluster(FrostySdk.Ebx.DebrisClusterData inData, Entity inParent)
        : base(inData, inParent)
    {
        Mesh = LoadedAssetManager.Instance.LoadAsset<Assets.MeshAsset>(this, Data.Mesh);
    }

    public override void CreateRenderProxy(List<RenderProxy> proxies, RenderCreateState state)
    {
        Mesh.LoadResource(state);
        proxies.Add(new ModelRenderProxy(state, this, Mesh.MeshData));

        SetFlags(EntityFlags.RenderProxyGenerated);
    }

    public override void Destroy()
    {
        LoadedAssetManager.Instance.UnloadAsset(Mesh);
    }
}

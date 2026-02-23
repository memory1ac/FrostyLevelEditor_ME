using Frosty.Core.Viewport;
using LevelEditorPlugin.Managers;
using LevelEditorPlugin.Render.Proxies;
using System.Collections.Generic;

namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DynamicModelEntityData))]
public class DynamicModelEntity : DynamicGamePhysicsEntity, IEntityData<FrostySdk.Ebx.DynamicModelEntityData>
{
    public new FrostySdk.Ebx.DynamicModelEntityData Data => data as FrostySdk.Ebx.DynamicModelEntityData;
    public Assets.MeshAsset Mesh { get; private set; }

    public DynamicModelEntity(FrostySdk.Ebx.DynamicModelEntityData inData, Entity inParent)
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

using Frosty.Core.Viewport;
using LevelEditorPlugin.Managers;
using LevelEditorPlugin.Render.Proxies;
using System.Collections.Generic;

namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BreakableModelEntityData))]
public class BreakableModelEntity : GamePhysicsEntity, IEntityData<FrostySdk.Ebx.BreakableModelEntityData>
{
    public new FrostySdk.Ebx.BreakableModelEntityData Data => data as FrostySdk.Ebx.BreakableModelEntityData;
    public Assets.MeshAsset Mesh { get; private set; }

    public BreakableModelEntity(FrostySdk.Ebx.BreakableModelEntityData inData, Entity inParent)
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

using Frosty.Core.Viewport;
using LevelEditorPlugin.Managers;
using LevelEditorPlugin.Render;
using LevelEditorPlugin.Render.Proxies;
using System.Collections.Generic;

namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.OBBCollisionEntityData))]
public class OBBCollisionEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.OBBCollisionEntityData>
{
    public new FrostySdk.Ebx.OBBCollisionEntityData Data => data as FrostySdk.Ebx.OBBCollisionEntityData;
    public ObjRenderable SpriteData { get; private set; }

    public override string DisplayName => "OBBCollisionEntity";

    public OBBCollisionEntity(FrostySdk.Ebx.OBBCollisionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }

    public override void CreateRenderProxy(List<RenderProxy> proxies, RenderCreateState state)
    {
        SpriteData = LoadedMeshManager.Instance.LoadMesh(state, "Sprite");

        var spriteRenderProxy = new SpriteRenderProxy(state, this, SpriteData, "Location");
        spriteRenderProxy.SetMeshCubeData(state, Data);
        proxies.Add(spriteRenderProxy);

        SetFlags(EntityFlags.RenderProxyGenerated);
    }

    public override void Destroy()
    {
        LoadedMeshManager.Instance.UnloadMesh(SpriteData);
    }
}

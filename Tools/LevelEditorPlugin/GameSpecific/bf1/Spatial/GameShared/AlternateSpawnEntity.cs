using Frosty.Core.Viewport;
using LevelEditorPlugin.Managers;
using LevelEditorPlugin.Render;
using LevelEditorPlugin.Render.Proxies;
using System.Collections.Generic;

namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AlternateSpawnEntityData))]
public class AlternateSpawnEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.AlternateSpawnEntityData>
{
    public new FrostySdk.Ebx.AlternateSpawnEntityData Data => data as FrostySdk.Ebx.AlternateSpawnEntityData;
    public ObjRenderable SpriteData { get; private set; }

    public override string DisplayName => "AlternateSpawnEntity";

    public AlternateSpawnEntity(FrostySdk.Ebx.AlternateSpawnEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }

    public override void CreateRenderProxy(List<RenderProxy> proxies, RenderCreateState state)
    {
        SpriteData = LoadedMeshManager.Instance.LoadMesh(state, "Sprite");

        if (Data.Team == FrostySdk.Ebx.TeamId.Team1)
        {
            var spriteRenderProxy = new SpriteRenderProxy(state, this, SpriteData, "SoldierSpawn1");
            spriteRenderProxy.SetMeshResPath(state, "gameplay/characters/soldiers/lowreschar_stand_Mesh");
            proxies.Add(spriteRenderProxy);
        }
        else
        {
            var spriteRenderProxy = new SpriteRenderProxy(state, this, SpriteData, "SoldierSpawn2");
            spriteRenderProxy.SetMeshResPath(state, "gameplay/characters/soldiers/lowreschar_crouch_Mesh");
            proxies.Add(spriteRenderProxy);
        }

        SetFlags(EntityFlags.RenderProxyGenerated);
    }

    public override void Destroy()
    {
        LoadedMeshManager.Instance.UnloadMesh(SpriteData);
    }
}

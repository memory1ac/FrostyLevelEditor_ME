using Frosty.Core.Viewport;
using LevelEditorPlugin.Managers;
using LevelEditorPlugin.Render;
using LevelEditorPlugin.Render.Proxies;
using System.Collections.Generic;

namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VehicleSpawnReferenceObjectData))]
public class VehicleSpawnReferenceObject : SpawnReferenceObject, IEntityData<FrostySdk.Ebx.VehicleSpawnReferenceObjectData>
{
    public new FrostySdk.Ebx.VehicleSpawnReferenceObjectData Data => data as FrostySdk.Ebx.VehicleSpawnReferenceObjectData;
    public ObjRenderable SpriteData { get; private set; }

    public VehicleSpawnReferenceObject(FrostySdk.Ebx.VehicleSpawnReferenceObjectData inData, Entity inParent)
        : base(inData, inParent)
    {
    }

    public override void CreateRenderProxy(List<RenderProxy> proxies, RenderCreateState state)
    {
        SpriteData = LoadedMeshManager.Instance.LoadMesh(state, "Sprite");

        var ownerDisplayName = owner.DisplayName;
        if (ownerDisplayName.StartsWith("SpawnerPrefab_Tanker"))
        {
            // 坦克模型
            var spriteRenderProxy = new SpriteRenderProxy(state, this, SpriteData, "VehicleSpawnTanker");
            spriteRenderProxy.SetMeshResPath(state, "gameplay/vehicles/gbr_markv/gbr_markv_lowpoly_Mesh");
            proxies.Add(spriteRenderProxy);
        }
        else if (ownerDisplayName.StartsWith("SpawnerPrefab_Pilot"))
        {
            // 飞机模型
            var spriteRenderProxy = new SpriteRenderProxy(state, this, SpriteData, "VehicleSpawnPilot");
            spriteRenderProxy.SetMeshResPath(state, "fx/mesh/specific/vehicles/airplanes/meshp_vehicle_fokkerdr1_Mesh");
            proxies.Add(spriteRenderProxy);
        }
        else if (ownerDisplayName.StartsWith("SpawnerPrefab_Cavalryman"))
        {
            // 骑兵模型
            var spriteRenderProxy = new SpriteRenderProxy(state, this, SpriteData, "VehicleSpawnRider");
            spriteRenderProxy.SetMeshResPath(state, "gameplay/vehicles/usa_harleydavidson_18j/usa_harleydavidson_18j_wreck_Mesh");
            proxies.Add(spriteRenderProxy);
        }
        else if (ownerDisplayName.StartsWith("SpawnerPrefab_CoastalAirship"))
        {
            // C级飞艇模型
            var spriteRenderProxy = new SpriteRenderProxy(state, this, SpriteData, "VehicleSpawnPilot");
            spriteRenderProxy.SetMeshResPath(state, "xpack3/gameplay/vehicles/ger_halberstadt_clii_staticwreck/da_ger_halberstadt_clii_staticwreck_Mesh");
            proxies.Add(spriteRenderProxy);
        }
        else if (ownerDisplayName.StartsWith("SpawnerPrefab_Destroyer"))
        {
            // 驱逐舰模型
            var spriteRenderProxy = new SpriteRenderProxy(state, this, SpriteData, "VehicleSpawnTanker");
            spriteRenderProxy.SetMeshResPath(state, "gameplay/vehicles/ita_mas/ita_mas_wreck_Mesh");
            proxies.Add(spriteRenderProxy);
        }
        else
        {
            // 定点武器
            var spriteRenderProxy = new SpriteRenderProxy(state, this, SpriteData, "VehicleSpawnTanker");
            spriteRenderProxy.SetMeshResPath(state, "gameplay/vehicles/ger_fk96/ger_fk_96_wreck_meshproxy_Mesh");
            proxies.Add(spriteRenderProxy);
        }

        SetFlags(EntityFlags.RenderProxyGenerated);
    }

    public override void Destroy()
    {
        LoadedMeshManager.Instance.UnloadMesh(SpriteData);
    }
}

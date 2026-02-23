namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetVehicleSpawnPointEntityData))]
public class BFUIGetVehicleSpawnPointEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetVehicleSpawnPointEntityData>
{
    public new FrostySdk.Ebx.BFUIGetVehicleSpawnPointEntityData Data => data as FrostySdk.Ebx.BFUIGetVehicleSpawnPointEntityData;
    public override string DisplayName => "BFUIGetVehicleSpawnPoint";

    public BFUIGetVehicleSpawnPointEntity(FrostySdk.Ebx.BFUIGetVehicleSpawnPointEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


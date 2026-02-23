namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetVehicleUnlockMetaDataEntityData))]
public class BFUIGetVehicleUnlockMetaDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetVehicleUnlockMetaDataEntityData>
{
    public new FrostySdk.Ebx.BFUIGetVehicleUnlockMetaDataEntityData Data => data as FrostySdk.Ebx.BFUIGetVehicleUnlockMetaDataEntityData;
    public override string DisplayName => "BFUIGetVehicleUnlockMetaData";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIGetVehicleUnlockMetaDataEntity(FrostySdk.Ebx.BFUIGetVehicleUnlockMetaDataEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


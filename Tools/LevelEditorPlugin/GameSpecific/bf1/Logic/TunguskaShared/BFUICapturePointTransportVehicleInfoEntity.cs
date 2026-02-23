namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUICapturePointTransportVehicleInfoEntityData))]
public class BFUICapturePointTransportVehicleInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUICapturePointTransportVehicleInfoEntityData>
{
    public new FrostySdk.Ebx.BFUICapturePointTransportVehicleInfoEntityData Data => data as FrostySdk.Ebx.BFUICapturePointTransportVehicleInfoEntityData;
    public override string DisplayName => "BFUICapturePointTransportVehicleInfo";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUICapturePointTransportVehicleInfoEntity(FrostySdk.Ebx.BFUICapturePointTransportVehicleInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIAirAssaultVehicleInfoEntityData))]
public class BFUIAirAssaultVehicleInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIAirAssaultVehicleInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIAirAssaultVehicleInfoEntityData Data => data as FrostySdk.Ebx.BFUIAirAssaultVehicleInfoEntityData;
    public override string DisplayName => "BFUIAirAssaultVehicleInfo";

    public BFUIAirAssaultVehicleInfoEntity(FrostySdk.Ebx.BFUIAirAssaultVehicleInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


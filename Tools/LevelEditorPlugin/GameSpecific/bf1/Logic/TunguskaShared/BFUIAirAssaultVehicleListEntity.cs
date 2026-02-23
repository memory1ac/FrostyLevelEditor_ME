namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIAirAssaultVehicleListEntityData))]
public class BFUIAirAssaultVehicleListEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIAirAssaultVehicleListEntityData>
{
    public new FrostySdk.Ebx.BFUIAirAssaultVehicleListEntityData Data => data as FrostySdk.Ebx.BFUIAirAssaultVehicleListEntityData;
    public override string DisplayName => "BFUIAirAssaultVehicleList";

    public BFUIAirAssaultVehicleListEntity(FrostySdk.Ebx.BFUIAirAssaultVehicleListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


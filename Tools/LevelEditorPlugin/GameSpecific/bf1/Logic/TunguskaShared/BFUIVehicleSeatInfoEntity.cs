namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIVehicleSeatInfoEntityData))]
public class BFUIVehicleSeatInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIVehicleSeatInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIVehicleSeatInfoEntityData Data => data as FrostySdk.Ebx.BFUIVehicleSeatInfoEntityData;
    public override string DisplayName => "BFUIVehicleSeatInfo";

    public BFUIVehicleSeatInfoEntity(FrostySdk.Ebx.BFUIVehicleSeatInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


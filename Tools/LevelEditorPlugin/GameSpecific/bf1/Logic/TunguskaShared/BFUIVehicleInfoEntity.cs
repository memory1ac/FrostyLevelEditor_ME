namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIVehicleInfoEntityData))]
public class BFUIVehicleInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIVehicleInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIVehicleInfoEntityData Data => data as FrostySdk.Ebx.BFUIVehicleInfoEntityData;
    public override string DisplayName => "BFUIVehicleInfo";

    public BFUIVehicleInfoEntity(FrostySdk.Ebx.BFUIVehicleInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


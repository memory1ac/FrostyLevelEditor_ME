namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIVehicleFilterEntityData))]
public class BFUIVehicleFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIVehicleFilterEntityData>
{
    public new FrostySdk.Ebx.BFUIVehicleFilterEntityData Data => data as FrostySdk.Ebx.BFUIVehicleFilterEntityData;
    public override string DisplayName => "BFUIVehicleFilter";

    public BFUIVehicleFilterEntity(FrostySdk.Ebx.BFUIVehicleFilterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


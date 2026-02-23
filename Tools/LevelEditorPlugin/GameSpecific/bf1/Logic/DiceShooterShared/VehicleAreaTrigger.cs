namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VehicleAreaTriggerData))]
public class VehicleAreaTrigger : LogicEntity, IEntityData<FrostySdk.Ebx.VehicleAreaTriggerData>
{
    public new FrostySdk.Ebx.VehicleAreaTriggerData Data => data as FrostySdk.Ebx.VehicleAreaTriggerData;
    public override string DisplayName => "VehicleAreaTrigger";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public VehicleAreaTrigger(FrostySdk.Ebx.VehicleAreaTriggerData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


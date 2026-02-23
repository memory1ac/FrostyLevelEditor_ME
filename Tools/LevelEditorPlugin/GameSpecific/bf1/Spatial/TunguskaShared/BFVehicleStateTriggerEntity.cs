namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFVehicleStateTriggerEntityData))]
public class BFVehicleStateTriggerEntity : VehicleStateTriggerEntity, IEntityData<FrostySdk.Ebx.BFVehicleStateTriggerEntityData>
{
    public new FrostySdk.Ebx.BFVehicleStateTriggerEntityData Data => data as FrostySdk.Ebx.BFVehicleStateTriggerEntityData;
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFVehicleStateTriggerEntity(FrostySdk.Ebx.BFVehicleStateTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


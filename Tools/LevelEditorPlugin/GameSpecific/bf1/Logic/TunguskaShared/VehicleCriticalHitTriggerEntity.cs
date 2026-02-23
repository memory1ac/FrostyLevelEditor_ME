namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VehicleCriticalHitTriggerEntityData))]
public class VehicleCriticalHitTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VehicleCriticalHitTriggerEntityData>
{
    public new FrostySdk.Ebx.VehicleCriticalHitTriggerEntityData Data => data as FrostySdk.Ebx.VehicleCriticalHitTriggerEntityData;
    public override string DisplayName => "VehicleCriticalHitTrigger";

    public VehicleCriticalHitTriggerEntity(FrostySdk.Ebx.VehicleCriticalHitTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


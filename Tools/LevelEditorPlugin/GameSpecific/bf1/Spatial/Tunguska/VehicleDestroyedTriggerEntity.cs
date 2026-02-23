namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VehicleDestroyedTriggerEntityData))]
public class VehicleDestroyedTriggerEntity : TriggerEntity, IEntityData<FrostySdk.Ebx.VehicleDestroyedTriggerEntityData>
{
    public new FrostySdk.Ebx.VehicleDestroyedTriggerEntityData Data => data as FrostySdk.Ebx.VehicleDestroyedTriggerEntityData;

    public VehicleDestroyedTriggerEntity(FrostySdk.Ebx.VehicleDestroyedTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


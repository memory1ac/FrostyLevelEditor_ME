namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayBatchSwitchTriggerEntityData))]
public class TimeOfDayBatchSwitchTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayBatchSwitchTriggerEntityData>
{
    public new FrostySdk.Ebx.TimeOfDayBatchSwitchTriggerEntityData Data => data as FrostySdk.Ebx.TimeOfDayBatchSwitchTriggerEntityData;
    public override string DisplayName => "TimeOfDayBatchSwitchTrigger";

    public TimeOfDayBatchSwitchTriggerEntity(FrostySdk.Ebx.TimeOfDayBatchSwitchTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ConsumableTriggerEntityData))]
public class ConsumableTriggerEntity : TriggerEntity, IEntityData<FrostySdk.Ebx.ConsumableTriggerEntityData>
{
    public new FrostySdk.Ebx.ConsumableTriggerEntityData Data => data as FrostySdk.Ebx.ConsumableTriggerEntityData;

    public ConsumableTriggerEntity(FrostySdk.Ebx.ConsumableTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


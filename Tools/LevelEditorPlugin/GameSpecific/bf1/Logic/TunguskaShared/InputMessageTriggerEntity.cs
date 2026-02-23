namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.InputMessageTriggerEntityData))]
public class InputMessageTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.InputMessageTriggerEntityData>
{
    public new FrostySdk.Ebx.InputMessageTriggerEntityData Data => data as FrostySdk.Ebx.InputMessageTriggerEntityData;
    public override string DisplayName => "InputMessageTrigger";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public InputMessageTriggerEntity(FrostySdk.Ebx.InputMessageTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


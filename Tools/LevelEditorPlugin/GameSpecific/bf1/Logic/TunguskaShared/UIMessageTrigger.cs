namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMessageTriggerData))]
public class UIMessageTrigger : LogicEntity, IEntityData<FrostySdk.Ebx.UIMessageTriggerData>
{
    public new FrostySdk.Ebx.UIMessageTriggerData Data => data as FrostySdk.Ebx.UIMessageTriggerData;
    public override string DisplayName => "UIMessageTrigger";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIMessageTrigger(FrostySdk.Ebx.UIMessageTriggerData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


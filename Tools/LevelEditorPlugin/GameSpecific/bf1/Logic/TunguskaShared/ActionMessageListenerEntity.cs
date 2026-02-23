namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ActionMessageListenerEntityData))]
public class ActionMessageListenerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ActionMessageListenerEntityData>
{
    public new FrostySdk.Ebx.ActionMessageListenerEntityData Data => data as FrostySdk.Ebx.ActionMessageListenerEntityData;
    public override string DisplayName => "ActionMessageListener";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ActionMessageListenerEntity(FrostySdk.Ebx.ActionMessageListenerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


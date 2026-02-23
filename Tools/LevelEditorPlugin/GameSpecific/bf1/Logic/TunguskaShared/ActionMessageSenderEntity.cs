namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ActionMessageSenderEntityData))]
public class ActionMessageSenderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ActionMessageSenderEntityData>
{
    public new FrostySdk.Ebx.ActionMessageSenderEntityData Data => data as FrostySdk.Ebx.ActionMessageSenderEntityData;
    public override string DisplayName => "ActionMessageSender";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ActionMessageSenderEntity(FrostySdk.Ebx.ActionMessageSenderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


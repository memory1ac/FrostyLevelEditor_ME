namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.StatMessageSenderEntityData))]
public class StatMessageSenderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StatMessageSenderEntityData>
{
    public new FrostySdk.Ebx.StatMessageSenderEntityData Data => data as FrostySdk.Ebx.StatMessageSenderEntityData;
    public override string DisplayName => "StatMessageSender";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public StatMessageSenderEntity(FrostySdk.Ebx.StatMessageSenderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISpartaNotificationSenderEntityData))]
public class UISpartaNotificationSenderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISpartaNotificationSenderEntityData>
{
    public new FrostySdk.Ebx.UISpartaNotificationSenderEntityData Data => data as FrostySdk.Ebx.UISpartaNotificationSenderEntityData;
    public override string DisplayName => "UISpartaNotificationSender";

    public UISpartaNotificationSenderEntity(FrostySdk.Ebx.UISpartaNotificationSenderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


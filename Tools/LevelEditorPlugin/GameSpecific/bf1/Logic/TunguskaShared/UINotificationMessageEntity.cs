namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UINotificationMessageEntityData))]
public class UINotificationMessageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UINotificationMessageEntityData>
{
    public new FrostySdk.Ebx.UINotificationMessageEntityData Data => data as FrostySdk.Ebx.UINotificationMessageEntityData;
    public override string DisplayName => "UINotificationMessage";

    public UINotificationMessageEntity(FrostySdk.Ebx.UINotificationMessageEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


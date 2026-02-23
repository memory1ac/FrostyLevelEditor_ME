namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UINotificationMessageWidgetData))]
public class UINotificationMessageWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UINotificationMessageWidgetData>
{
    public new FrostySdk.Ebx.UINotificationMessageWidgetData Data => data as FrostySdk.Ebx.UINotificationMessageWidgetData;
    public override string DisplayName => "UINotificationMessageWidget";

    public UINotificationMessageWidget(FrostySdk.Ebx.UINotificationMessageWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


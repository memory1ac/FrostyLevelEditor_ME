namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPopupWidgetData))]
public class UIPopupWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIPopupWidgetData>
{
    public new FrostySdk.Ebx.UIPopupWidgetData Data => data as FrostySdk.Ebx.UIPopupWidgetData;
    public override string DisplayName => "UIPopupWidget";

    public UIPopupWidget(FrostySdk.Ebx.UIPopupWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


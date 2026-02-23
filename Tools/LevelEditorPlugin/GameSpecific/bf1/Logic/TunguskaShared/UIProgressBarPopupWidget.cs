namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIProgressBarPopupWidgetData))]
public class UIProgressBarPopupWidget : UIGenericPopupWidget, IEntityData<FrostySdk.Ebx.UIProgressBarPopupWidgetData>
{
    public new FrostySdk.Ebx.UIProgressBarPopupWidgetData Data => data as FrostySdk.Ebx.UIProgressBarPopupWidgetData;
    public override string DisplayName => "UIProgressBarPopupWidget";

    public UIProgressBarPopupWidget(FrostySdk.Ebx.UIProgressBarPopupWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


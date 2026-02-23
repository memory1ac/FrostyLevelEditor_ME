namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIVisualGuideWidgetData))]
public class UIVisualGuideWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIVisualGuideWidgetData>
{
    public new FrostySdk.Ebx.UIVisualGuideWidgetData Data => data as FrostySdk.Ebx.UIVisualGuideWidgetData;
    public override string DisplayName => "UIVisualGuideWidget";

    public UIVisualGuideWidget(FrostySdk.Ebx.UIVisualGuideWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


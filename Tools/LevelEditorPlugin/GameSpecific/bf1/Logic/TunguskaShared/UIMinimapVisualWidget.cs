namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMinimapVisualWidgetData))]
public class UIMinimapVisualWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMinimapVisualWidgetData>
{
    public new FrostySdk.Ebx.UIMinimapVisualWidgetData Data => data as FrostySdk.Ebx.UIMinimapVisualWidgetData;
    public override string DisplayName => "UIMinimapVisualWidget";

    public UIMinimapVisualWidget(FrostySdk.Ebx.UIMinimapVisualWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


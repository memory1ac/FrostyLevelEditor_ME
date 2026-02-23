namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPerformanceTestWidgetData))]
public class UIPerformanceTestWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIPerformanceTestWidgetData>
{
    public new FrostySdk.Ebx.UIPerformanceTestWidgetData Data => data as FrostySdk.Ebx.UIPerformanceTestWidgetData;
    public override string DisplayName => "UIPerformanceTestWidget";

    public UIPerformanceTestWidget(FrostySdk.Ebx.UIPerformanceTestWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBreakthroughPreEorWidgetData))]
public class UIBreakthroughPreEorWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIBreakthroughPreEorWidgetData>
{
    public new FrostySdk.Ebx.UIBreakthroughPreEorWidgetData Data => data as FrostySdk.Ebx.UIBreakthroughPreEorWidgetData;
    public override string DisplayName => "UIBreakthroughPreEorWidget";

    public UIBreakthroughPreEorWidget(FrostySdk.Ebx.UIBreakthroughPreEorWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


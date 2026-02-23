namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBreakthroughEorProgressWidgetData))]
public class UIBreakthroughEorProgressWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIBreakthroughEorProgressWidgetData>
{
    public new FrostySdk.Ebx.UIBreakthroughEorProgressWidgetData Data => data as FrostySdk.Ebx.UIBreakthroughEorProgressWidgetData;
    public override string DisplayName => "UIBreakthroughEorProgressWidget";

    public UIBreakthroughEorProgressWidget(FrostySdk.Ebx.UIBreakthroughEorProgressWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


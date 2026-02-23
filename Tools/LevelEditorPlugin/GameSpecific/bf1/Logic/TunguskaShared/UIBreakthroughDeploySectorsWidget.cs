namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBreakthroughDeploySectorsWidgetData))]
public class UIBreakthroughDeploySectorsWidget : UIShapeBase, IEntityData<FrostySdk.Ebx.UIBreakthroughDeploySectorsWidgetData>
{
    public new FrostySdk.Ebx.UIBreakthroughDeploySectorsWidgetData Data => data as FrostySdk.Ebx.UIBreakthroughDeploySectorsWidgetData;
    public override string DisplayName => "UIBreakthroughDeploySectorsWidget";

    public UIBreakthroughDeploySectorsWidget(FrostySdk.Ebx.UIBreakthroughDeploySectorsWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


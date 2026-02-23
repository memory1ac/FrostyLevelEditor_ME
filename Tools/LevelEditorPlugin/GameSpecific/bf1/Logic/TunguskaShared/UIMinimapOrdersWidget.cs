namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMinimapOrdersWidgetData))]
public class UIMinimapOrdersWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMinimapOrdersWidgetData>
{
    public new FrostySdk.Ebx.UIMinimapOrdersWidgetData Data => data as FrostySdk.Ebx.UIMinimapOrdersWidgetData;
    public override string DisplayName => "UIMinimapOrdersWidget";

    public UIMinimapOrdersWidget(FrostySdk.Ebx.UIMinimapOrdersWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


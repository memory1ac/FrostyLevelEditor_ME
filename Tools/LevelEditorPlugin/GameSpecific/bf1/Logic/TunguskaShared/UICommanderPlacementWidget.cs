namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommanderPlacementWidgetData))]
public class UICommanderPlacementWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICommanderPlacementWidgetData>
{
    public new FrostySdk.Ebx.UICommanderPlacementWidgetData Data => data as FrostySdk.Ebx.UICommanderPlacementWidgetData;
    public override string DisplayName => "UICommanderPlacementWidget";

    public UICommanderPlacementWidget(FrostySdk.Ebx.UICommanderPlacementWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


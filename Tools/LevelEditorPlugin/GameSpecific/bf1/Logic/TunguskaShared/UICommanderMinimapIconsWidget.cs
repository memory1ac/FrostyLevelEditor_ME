namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommanderMinimapIconsWidgetData))]
public class UICommanderMinimapIconsWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICommanderMinimapIconsWidgetData>
{
    public new FrostySdk.Ebx.UICommanderMinimapIconsWidgetData Data => data as FrostySdk.Ebx.UICommanderMinimapIconsWidgetData;
    public override string DisplayName => "UICommanderMinimapIconsWidget";

    public UICommanderMinimapIconsWidget(FrostySdk.Ebx.UICommanderMinimapIconsWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


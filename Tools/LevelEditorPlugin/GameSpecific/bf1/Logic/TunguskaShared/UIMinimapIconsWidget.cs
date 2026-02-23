namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMinimapIconsWidgetData))]
public class UIMinimapIconsWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMinimapIconsWidgetData>
{
    public new FrostySdk.Ebx.UIMinimapIconsWidgetData Data => data as FrostySdk.Ebx.UIMinimapIconsWidgetData;
    public override string DisplayName => "UIMinimapIconsWidget";

    public UIMinimapIconsWidget(FrostySdk.Ebx.UIMinimapIconsWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


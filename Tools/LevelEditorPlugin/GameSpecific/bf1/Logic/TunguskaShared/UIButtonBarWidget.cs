namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIButtonBarWidgetData))]
public class UIButtonBarWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIButtonBarWidgetData>
{
    public new FrostySdk.Ebx.UIButtonBarWidgetData Data => data as FrostySdk.Ebx.UIButtonBarWidgetData;
    public override string DisplayName => "UIButtonBarWidget";

    public UIButtonBarWidget(FrostySdk.Ebx.UIButtonBarWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMenuListEntryWidgetData))]
public class UIMenuListEntryWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMenuListEntryWidgetData>
{
    public new FrostySdk.Ebx.UIMenuListEntryWidgetData Data => data as FrostySdk.Ebx.UIMenuListEntryWidgetData;
    public override string DisplayName => "UIMenuListEntryWidget";

    public UIMenuListEntryWidget(FrostySdk.Ebx.UIMenuListEntryWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMenuListWidgetData))]
public class UIMenuListWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMenuListWidgetData>
{
    public new FrostySdk.Ebx.UIMenuListWidgetData Data => data as FrostySdk.Ebx.UIMenuListWidgetData;
    public override string DisplayName => "UIMenuListWidget";

    public UIMenuListWidget(FrostySdk.Ebx.UIMenuListWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


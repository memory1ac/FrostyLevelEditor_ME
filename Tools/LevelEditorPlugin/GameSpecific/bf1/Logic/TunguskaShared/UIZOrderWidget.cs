namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIZOrderWidgetData))]
public class UIZOrderWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIZOrderWidgetData>
{
    public new FrostySdk.Ebx.UIZOrderWidgetData Data => data as FrostySdk.Ebx.UIZOrderWidgetData;
    public override string DisplayName => "UIZOrderWidget";

    public UIZOrderWidget(FrostySdk.Ebx.UIZOrderWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


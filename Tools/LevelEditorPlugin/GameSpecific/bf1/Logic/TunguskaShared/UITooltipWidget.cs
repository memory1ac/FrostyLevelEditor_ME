namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UITooltipWidgetData))]
public class UITooltipWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UITooltipWidgetData>
{
    public new FrostySdk.Ebx.UITooltipWidgetData Data => data as FrostySdk.Ebx.UITooltipWidgetData;
    public override string DisplayName => "UITooltipWidget";

    public UITooltipWidget(FrostySdk.Ebx.UITooltipWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


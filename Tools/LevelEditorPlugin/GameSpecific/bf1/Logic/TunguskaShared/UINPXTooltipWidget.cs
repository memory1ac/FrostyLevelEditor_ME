namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UINPXTooltipWidgetData))]
public class UINPXTooltipWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UINPXTooltipWidgetData>
{
    public new FrostySdk.Ebx.UINPXTooltipWidgetData Data => data as FrostySdk.Ebx.UINPXTooltipWidgetData;
    public override string DisplayName => "UINPXTooltipWidget";

    public UINPXTooltipWidget(FrostySdk.Ebx.UINPXTooltipWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


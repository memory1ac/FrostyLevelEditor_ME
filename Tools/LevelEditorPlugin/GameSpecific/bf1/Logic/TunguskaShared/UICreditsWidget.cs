namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICreditsWidgetData))]
public class UICreditsWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICreditsWidgetData>
{
    public new FrostySdk.Ebx.UICreditsWidgetData Data => data as FrostySdk.Ebx.UICreditsWidgetData;
    public override string DisplayName => "UICreditsWidget";

    public UICreditsWidget(FrostySdk.Ebx.UICreditsWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


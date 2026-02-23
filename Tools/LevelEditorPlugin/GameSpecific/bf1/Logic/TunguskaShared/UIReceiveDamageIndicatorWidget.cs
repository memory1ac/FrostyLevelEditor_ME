namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIReceiveDamageIndicatorWidgetData))]
public class UIReceiveDamageIndicatorWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIReceiveDamageIndicatorWidgetData>
{
    public new FrostySdk.Ebx.UIReceiveDamageIndicatorWidgetData Data => data as FrostySdk.Ebx.UIReceiveDamageIndicatorWidgetData;
    public override string DisplayName => "UIReceiveDamageIndicatorWidget";

    public UIReceiveDamageIndicatorWidget(FrostySdk.Ebx.UIReceiveDamageIndicatorWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


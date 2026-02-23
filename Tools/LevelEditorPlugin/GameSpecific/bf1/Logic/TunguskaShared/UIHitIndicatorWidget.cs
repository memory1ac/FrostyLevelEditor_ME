namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIHitIndicatorWidgetData))]
public class UIHitIndicatorWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIHitIndicatorWidgetData>
{
    public new FrostySdk.Ebx.UIHitIndicatorWidgetData Data => data as FrostySdk.Ebx.UIHitIndicatorWidgetData;
    public override string DisplayName => "UIHitIndicatorWidget";

    public UIHitIndicatorWidget(FrostySdk.Ebx.UIHitIndicatorWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


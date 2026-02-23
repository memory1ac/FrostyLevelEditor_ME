namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISensingIndicatorWidgetData))]
public class UISensingIndicatorWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UISensingIndicatorWidgetData>
{
    public new FrostySdk.Ebx.UISensingIndicatorWidgetData Data => data as FrostySdk.Ebx.UISensingIndicatorWidgetData;
    public override string DisplayName => "UISensingIndicatorWidget";

    public UISensingIndicatorWidget(FrostySdk.Ebx.UISensingIndicatorWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


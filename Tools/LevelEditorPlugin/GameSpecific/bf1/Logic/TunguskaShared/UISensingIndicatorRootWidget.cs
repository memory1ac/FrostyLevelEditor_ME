namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISensingIndicatorRootWidgetData))]
public class UISensingIndicatorRootWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UISensingIndicatorRootWidgetData>
{
    public new FrostySdk.Ebx.UISensingIndicatorRootWidgetData Data => data as FrostySdk.Ebx.UISensingIndicatorRootWidgetData;
    public override string DisplayName => "UISensingIndicatorRootWidget";

    public UISensingIndicatorRootWidget(FrostySdk.Ebx.UISensingIndicatorRootWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


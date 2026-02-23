namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISPLoadingWidgetData))]
public class UISPLoadingWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UISPLoadingWidgetData>
{
    public new FrostySdk.Ebx.UISPLoadingWidgetData Data => data as FrostySdk.Ebx.UISPLoadingWidgetData;
    public override string DisplayName => "UISPLoadingWidget";

    public UISPLoadingWidget(FrostySdk.Ebx.UISPLoadingWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


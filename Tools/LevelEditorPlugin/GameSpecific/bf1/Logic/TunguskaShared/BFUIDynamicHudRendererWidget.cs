namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIDynamicHudRendererWidgetData))]
public class BFUIDynamicHudRendererWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUIDynamicHudRendererWidgetData>
{
    public new FrostySdk.Ebx.BFUIDynamicHudRendererWidgetData Data => data as FrostySdk.Ebx.BFUIDynamicHudRendererWidgetData;
    public override string DisplayName => "BFUIDynamicHudRendererWidget";

    public BFUIDynamicHudRendererWidget(FrostySdk.Ebx.BFUIDynamicHudRendererWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


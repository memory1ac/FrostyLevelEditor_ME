namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUICrosshairProjectionWidgetData))]
public class BFUICrosshairProjectionWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUICrosshairProjectionWidgetData>
{
    public new FrostySdk.Ebx.BFUICrosshairProjectionWidgetData Data => data as FrostySdk.Ebx.BFUICrosshairProjectionWidgetData;
    public override string DisplayName => "BFUICrosshairProjectionWidget";

    public BFUICrosshairProjectionWidget(FrostySdk.Ebx.BFUICrosshairProjectionWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


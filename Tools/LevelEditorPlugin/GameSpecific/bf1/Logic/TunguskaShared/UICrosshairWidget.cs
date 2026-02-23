namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICrosshairWidgetData))]
public class UICrosshairWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICrosshairWidgetData>
{
    public new FrostySdk.Ebx.UICrosshairWidgetData Data => data as FrostySdk.Ebx.UICrosshairWidgetData;
    public override string DisplayName => "UICrosshairWidget";

    public UICrosshairWidget(FrostySdk.Ebx.UICrosshairWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICapturePointShapeWidgetData))]
public class UICapturePointShapeWidget : UIShapeBase, IEntityData<FrostySdk.Ebx.UICapturePointShapeWidgetData>
{
    public new FrostySdk.Ebx.UICapturePointShapeWidgetData Data => data as FrostySdk.Ebx.UICapturePointShapeWidgetData;
    public override string DisplayName => "UICapturePointShapeWidget";

    public UICapturePointShapeWidget(FrostySdk.Ebx.UICapturePointShapeWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


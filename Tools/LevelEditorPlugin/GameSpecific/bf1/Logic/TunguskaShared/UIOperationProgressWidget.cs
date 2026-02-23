namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIOperationProgressWidgetData))]
public class UIOperationProgressWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIOperationProgressWidgetData>
{
    public new FrostySdk.Ebx.UIOperationProgressWidgetData Data => data as FrostySdk.Ebx.UIOperationProgressWidgetData;
    public override string DisplayName => "UIOperationProgressWidget";

    public UIOperationProgressWidget(FrostySdk.Ebx.UIOperationProgressWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


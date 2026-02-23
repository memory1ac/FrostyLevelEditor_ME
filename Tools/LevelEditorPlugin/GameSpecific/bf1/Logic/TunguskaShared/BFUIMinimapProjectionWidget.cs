namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIMinimapProjectionWidgetData))]
public class BFUIMinimapProjectionWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUIMinimapProjectionWidgetData>
{
    public new FrostySdk.Ebx.BFUIMinimapProjectionWidgetData Data => data as FrostySdk.Ebx.BFUIMinimapProjectionWidgetData;
    public override string DisplayName => "BFUIMinimapProjectionWidget";

    public BFUIMinimapProjectionWidget(FrostySdk.Ebx.BFUIMinimapProjectionWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


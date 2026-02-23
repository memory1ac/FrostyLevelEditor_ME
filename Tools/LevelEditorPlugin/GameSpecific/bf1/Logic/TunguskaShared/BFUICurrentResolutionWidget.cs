namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUICurrentResolutionWidgetData))]
public class BFUICurrentResolutionWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUICurrentResolutionWidgetData>
{
    public new FrostySdk.Ebx.BFUICurrentResolutionWidgetData Data => data as FrostySdk.Ebx.BFUICurrentResolutionWidgetData;
    public override string DisplayName => "BFUICurrentResolutionWidget";

    public BFUICurrentResolutionWidget(FrostySdk.Ebx.BFUICurrentResolutionWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


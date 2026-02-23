namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DRootWidgetData))]
public class UIDeploy3DRootWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DRootWidgetData>
{
    public new FrostySdk.Ebx.UIDeploy3DRootWidgetData Data => data as FrostySdk.Ebx.UIDeploy3DRootWidgetData;
    public override string DisplayName => "UIDeploy3DRootWidget";

    public UIDeploy3DRootWidget(FrostySdk.Ebx.UIDeploy3DRootWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


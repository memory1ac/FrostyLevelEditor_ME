namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DBaseSpawnWidgetSelectorWidgetData))]
public class UIDeploy3DBaseSpawnWidgetSelectorWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DBaseSpawnWidgetSelectorWidgetData>
{
    public new FrostySdk.Ebx.UIDeploy3DBaseSpawnWidgetSelectorWidgetData Data => data as FrostySdk.Ebx.UIDeploy3DBaseSpawnWidgetSelectorWidgetData;
    public override string DisplayName => "UIDeploy3DBaseSpawnWidgetSelectorWidget";

    public UIDeploy3DBaseSpawnWidgetSelectorWidget(FrostySdk.Ebx.UIDeploy3DBaseSpawnWidgetSelectorWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


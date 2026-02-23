namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DMobileSpawnSelectorWidgetData))]
public class UIDeploy3DMobileSpawnSelectorWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DMobileSpawnSelectorWidgetData>
{
    public new FrostySdk.Ebx.UIDeploy3DMobileSpawnSelectorWidgetData Data => data as FrostySdk.Ebx.UIDeploy3DMobileSpawnSelectorWidgetData;
    public override string DisplayName => "UIDeploy3DMobileSpawnSelectorWidget";

    public UIDeploy3DMobileSpawnSelectorWidget(FrostySdk.Ebx.UIDeploy3DMobileSpawnSelectorWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


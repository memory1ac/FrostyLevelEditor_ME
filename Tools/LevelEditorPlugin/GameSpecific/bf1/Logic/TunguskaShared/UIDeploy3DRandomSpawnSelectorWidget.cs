namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DRandomSpawnSelectorWidgetData))]
public class UIDeploy3DRandomSpawnSelectorWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DRandomSpawnSelectorWidgetData>
{
    public new FrostySdk.Ebx.UIDeploy3DRandomSpawnSelectorWidgetData Data => data as FrostySdk.Ebx.UIDeploy3DRandomSpawnSelectorWidgetData;
    public override string DisplayName => "UIDeploy3DRandomSpawnSelectorWidget";

    public UIDeploy3DRandomSpawnSelectorWidget(FrostySdk.Ebx.UIDeploy3DRandomSpawnSelectorWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


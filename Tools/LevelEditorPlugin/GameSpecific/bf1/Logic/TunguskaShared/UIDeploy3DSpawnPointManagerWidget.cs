namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DSpawnPointManagerWidgetData))]
public class UIDeploy3DSpawnPointManagerWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DSpawnPointManagerWidgetData>
{
    public new FrostySdk.Ebx.UIDeploy3DSpawnPointManagerWidgetData Data => data as FrostySdk.Ebx.UIDeploy3DSpawnPointManagerWidgetData;
    public override string DisplayName => "UIDeploy3DSpawnPointManagerWidget";

    public UIDeploy3DSpawnPointManagerWidget(FrostySdk.Ebx.UIDeploy3DSpawnPointManagerWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


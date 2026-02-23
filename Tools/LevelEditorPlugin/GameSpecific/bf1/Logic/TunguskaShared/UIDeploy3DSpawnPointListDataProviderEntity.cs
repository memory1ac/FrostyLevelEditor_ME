namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DSpawnPointListDataProviderEntityData))]
public class UIDeploy3DSpawnPointListDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DSpawnPointListDataProviderEntityData>
{
    public new FrostySdk.Ebx.UIDeploy3DSpawnPointListDataProviderEntityData Data => data as FrostySdk.Ebx.UIDeploy3DSpawnPointListDataProviderEntityData;
    public override string DisplayName => "UIDeploy3DSpawnPointListDataProvider";

    public UIDeploy3DSpawnPointListDataProviderEntity(FrostySdk.Ebx.UIDeploy3DSpawnPointListDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


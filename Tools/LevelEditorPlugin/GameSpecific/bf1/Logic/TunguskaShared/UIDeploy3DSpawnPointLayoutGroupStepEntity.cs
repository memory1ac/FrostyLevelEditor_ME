namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DSpawnPointLayoutGroupStepEntityData))]
public class UIDeploy3DSpawnPointLayoutGroupStepEntity : BFUILayoutGroupStepEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DSpawnPointLayoutGroupStepEntityData>
{
    public new FrostySdk.Ebx.UIDeploy3DSpawnPointLayoutGroupStepEntityData Data => data as FrostySdk.Ebx.UIDeploy3DSpawnPointLayoutGroupStepEntityData;
    public override string DisplayName => "UIDeploy3DSpawnPointLayoutGroupStep";

    public UIDeploy3DSpawnPointLayoutGroupStepEntity(FrostySdk.Ebx.UIDeploy3DSpawnPointLayoutGroupStepEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


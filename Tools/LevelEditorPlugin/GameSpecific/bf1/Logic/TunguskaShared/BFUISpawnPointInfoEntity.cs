namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISpawnPointInfoEntityData))]
public class BFUISpawnPointInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISpawnPointInfoEntityData>
{
    public new FrostySdk.Ebx.BFUISpawnPointInfoEntityData Data => data as FrostySdk.Ebx.BFUISpawnPointInfoEntityData;
    public override string DisplayName => "BFUISpawnPointInfo";

    public BFUISpawnPointInfoEntity(FrostySdk.Ebx.BFUISpawnPointInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISelectSpawnPointEntityData))]
public class BFUISelectSpawnPointEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISelectSpawnPointEntityData>
{
    public new FrostySdk.Ebx.BFUISelectSpawnPointEntityData Data => data as FrostySdk.Ebx.BFUISelectSpawnPointEntityData;
    public override string DisplayName => "BFUISelectSpawnPoint";

    public BFUISelectSpawnPointEntity(FrostySdk.Ebx.BFUISelectSpawnPointEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


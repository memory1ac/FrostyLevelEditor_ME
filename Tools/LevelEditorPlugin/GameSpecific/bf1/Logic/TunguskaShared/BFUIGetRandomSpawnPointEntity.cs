namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetRandomSpawnPointEntityData))]
public class BFUIGetRandomSpawnPointEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetRandomSpawnPointEntityData>
{
    public new FrostySdk.Ebx.BFUIGetRandomSpawnPointEntityData Data => data as FrostySdk.Ebx.BFUIGetRandomSpawnPointEntityData;
    public override string DisplayName => "BFUIGetRandomSpawnPoint";

    public BFUIGetRandomSpawnPointEntity(FrostySdk.Ebx.BFUIGetRandomSpawnPointEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


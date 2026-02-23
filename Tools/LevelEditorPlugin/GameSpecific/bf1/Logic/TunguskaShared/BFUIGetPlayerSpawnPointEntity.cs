namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetPlayerSpawnPointEntityData))]
public class BFUIGetPlayerSpawnPointEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetPlayerSpawnPointEntityData>
{
    public new FrostySdk.Ebx.BFUIGetPlayerSpawnPointEntityData Data => data as FrostySdk.Ebx.BFUIGetPlayerSpawnPointEntityData;
    public override string DisplayName => "BFUIGetPlayerSpawnPoint";

    public BFUIGetPlayerSpawnPointEntity(FrostySdk.Ebx.BFUIGetPlayerSpawnPointEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISpecialSpawnPointInfoEntityData))]
public class BFUISpecialSpawnPointInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISpecialSpawnPointInfoEntityData>
{
    public new FrostySdk.Ebx.BFUISpecialSpawnPointInfoEntityData Data => data as FrostySdk.Ebx.BFUISpecialSpawnPointInfoEntityData;
    public override string DisplayName => "BFUISpecialSpawnPointInfo";

    public BFUISpecialSpawnPointInfoEntity(FrostySdk.Ebx.BFUISpecialSpawnPointInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


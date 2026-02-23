namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpawnerGroupEntityData))]
public class SpawnerGroupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpawnerGroupEntityData>
{
    public new FrostySdk.Ebx.SpawnerGroupEntityData Data => data as FrostySdk.Ebx.SpawnerGroupEntityData;
    public override string DisplayName => "SpawnerGroup";

    public SpawnerGroupEntity(FrostySdk.Ebx.SpawnerGroupEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


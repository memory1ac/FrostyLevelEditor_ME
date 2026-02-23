namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontLineSpawnEntityData))]
public class FrontLineSpawnEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FrontLineSpawnEntityData>
{
    public new FrostySdk.Ebx.FrontLineSpawnEntityData Data => data as FrostySdk.Ebx.FrontLineSpawnEntityData;
    public override string DisplayName => "FrontLineSpawn";

    public FrontLineSpawnEntity(FrostySdk.Ebx.FrontLineSpawnEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


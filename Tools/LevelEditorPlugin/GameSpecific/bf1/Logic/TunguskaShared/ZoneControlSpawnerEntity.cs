namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ZoneControlSpawnerEntityData))]
public class ZoneControlSpawnerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ZoneControlSpawnerEntityData>
{
    public new FrostySdk.Ebx.ZoneControlSpawnerEntityData Data => data as FrostySdk.Ebx.ZoneControlSpawnerEntityData;
    public override string DisplayName => "ZoneControlSpawner";

    public ZoneControlSpawnerEntity(FrostySdk.Ebx.ZoneControlSpawnerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


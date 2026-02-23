namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.RandomTerrainPositionEntityData))]
public class RandomTerrainPositionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.RandomTerrainPositionEntityData>
{
    public new FrostySdk.Ebx.RandomTerrainPositionEntityData Data => data as FrostySdk.Ebx.RandomTerrainPositionEntityData;
    public override string DisplayName => "RandomTerrainPosition";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public RandomTerrainPositionEntity(FrostySdk.Ebx.RandomTerrainPositionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


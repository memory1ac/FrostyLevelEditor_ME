namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TerrainSampleStrategyCircleEntityData))]
public class TerrainSampleStrategyCircleEntity : TerrainSampleStrategy, IEntityData<FrostySdk.Ebx.TerrainSampleStrategyCircleEntityData>
{
    public new FrostySdk.Ebx.TerrainSampleStrategyCircleEntityData Data => data as FrostySdk.Ebx.TerrainSampleStrategyCircleEntityData;
    public override string DisplayName => "TerrainSampleStrategyCircle";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TerrainSampleStrategyCircleEntity(FrostySdk.Ebx.TerrainSampleStrategyCircleEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


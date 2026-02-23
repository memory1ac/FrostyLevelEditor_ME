namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TerrainSampleStrategyData))]
public class TerrainSampleStrategy : LogicEntity, IEntityData<FrostySdk.Ebx.TerrainSampleStrategyData>
{
    public new FrostySdk.Ebx.TerrainSampleStrategyData Data => data as FrostySdk.Ebx.TerrainSampleStrategyData;
    public override string DisplayName => "TerrainSampleStrategy";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TerrainSampleStrategy(FrostySdk.Ebx.TerrainSampleStrategyData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TerrainSampleStrategyForwardEntityData))]
public class TerrainSampleStrategyForwardEntity : TerrainSampleStrategy, IEntityData<FrostySdk.Ebx.TerrainSampleStrategyForwardEntityData>
{
    public new FrostySdk.Ebx.TerrainSampleStrategyForwardEntityData Data => data as FrostySdk.Ebx.TerrainSampleStrategyForwardEntityData;
    public override string DisplayName => "TerrainSampleStrategyForward";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TerrainSampleStrategyForwardEntity(FrostySdk.Ebx.TerrainSampleStrategyForwardEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


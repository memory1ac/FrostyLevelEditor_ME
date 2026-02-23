namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TerrainHeightSampleEntityData))]
public class TerrainHeightSampleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TerrainHeightSampleEntityData>
{
    public new FrostySdk.Ebx.TerrainHeightSampleEntityData Data => data as FrostySdk.Ebx.TerrainHeightSampleEntityData;
    public override string DisplayName => "TerrainHeightSample";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TerrainHeightSampleEntity(FrostySdk.Ebx.TerrainHeightSampleEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


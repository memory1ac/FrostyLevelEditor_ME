namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TerrainDegradationAreaEntityData))]
public class TerrainDegradationAreaEntity : TileAreaEntity, IEntityData<FrostySdk.Ebx.TerrainDegradationAreaEntityData>
{
    public new FrostySdk.Ebx.TerrainDegradationAreaEntityData Data => data as FrostySdk.Ebx.TerrainDegradationAreaEntityData;
    public override string DisplayName => "TerrainDegradationArea";

    public TerrainDegradationAreaEntity(FrostySdk.Ebx.TerrainDegradationAreaEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


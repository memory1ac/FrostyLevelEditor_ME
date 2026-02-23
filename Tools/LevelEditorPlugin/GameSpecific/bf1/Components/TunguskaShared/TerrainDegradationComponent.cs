
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TerrainDegradationComponentData))]
public class TerrainDegradationComponent : GameComponent, IEntityData<FrostySdk.Ebx.TerrainDegradationComponentData>
{
    public new FrostySdk.Ebx.TerrainDegradationComponentData Data => data as FrostySdk.Ebx.TerrainDegradationComponentData;
    public override string DisplayName => "TerrainDegradationComponent";

    public TerrainDegradationComponent(FrostySdk.Ebx.TerrainDegradationComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


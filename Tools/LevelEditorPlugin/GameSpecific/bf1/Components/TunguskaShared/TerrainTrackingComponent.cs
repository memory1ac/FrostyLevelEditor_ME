
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TerrainTrackingComponentData))]
public class TerrainTrackingComponent : GameComponent, IEntityData<FrostySdk.Ebx.TerrainTrackingComponentData>
{
    public new FrostySdk.Ebx.TerrainTrackingComponentData Data => data as FrostySdk.Ebx.TerrainTrackingComponentData;
    public override string DisplayName => "TerrainTrackingComponent";

    public TerrainTrackingComponent(FrostySdk.Ebx.TerrainTrackingComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


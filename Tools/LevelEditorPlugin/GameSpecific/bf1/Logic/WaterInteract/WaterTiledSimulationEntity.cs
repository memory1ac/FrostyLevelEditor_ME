namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WaterTiledSimulationEntityData))]
public class WaterTiledSimulationEntity : WaterSimulationEntity, IEntityData<FrostySdk.Ebx.WaterTiledSimulationEntityData>
{
    public new FrostySdk.Ebx.WaterTiledSimulationEntityData Data => data as FrostySdk.Ebx.WaterTiledSimulationEntityData;
    public override string DisplayName => "WaterTiledSimulation";

    public WaterTiledSimulationEntity(FrostySdk.Ebx.WaterTiledSimulationEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WaterSimulationEntityData))]
public class WaterSimulationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WaterSimulationEntityData>
{
    public new FrostySdk.Ebx.WaterSimulationEntityData Data => data as FrostySdk.Ebx.WaterSimulationEntityData;
    public override string DisplayName => "WaterSimulation";

    public WaterSimulationEntity(FrostySdk.Ebx.WaterSimulationEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


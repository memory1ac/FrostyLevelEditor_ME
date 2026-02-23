namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WaterFftSimulationTileEntityData))]
public class WaterFftSimulationTileEntity : WaterSimulationEntity, IEntityData<FrostySdk.Ebx.WaterFftSimulationTileEntityData>
{
    public new FrostySdk.Ebx.WaterFftSimulationTileEntityData Data => data as FrostySdk.Ebx.WaterFftSimulationTileEntityData;
    public override string DisplayName => "WaterFftSimulationTile";

    public WaterFftSimulationTileEntity(FrostySdk.Ebx.WaterFftSimulationTileEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


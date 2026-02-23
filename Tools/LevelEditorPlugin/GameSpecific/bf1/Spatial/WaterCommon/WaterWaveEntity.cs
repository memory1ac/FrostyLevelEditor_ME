namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WaterWaveEntityData))]
public class WaterWaveEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.WaterWaveEntityData>
{
    public new FrostySdk.Ebx.WaterWaveEntityData Data => data as FrostySdk.Ebx.WaterWaveEntityData;

    public WaterWaveEntity(FrostySdk.Ebx.WaterWaveEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


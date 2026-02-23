
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.RadarSweepComponentData))]
public class RadarSweepComponent : GameComponent, IEntityData<FrostySdk.Ebx.RadarSweepComponentData>
{
    public new FrostySdk.Ebx.RadarSweepComponentData Data => data as FrostySdk.Ebx.RadarSweepComponentData;
    public override string DisplayName => "RadarSweepComponent";

    public RadarSweepComponent(FrostySdk.Ebx.RadarSweepComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


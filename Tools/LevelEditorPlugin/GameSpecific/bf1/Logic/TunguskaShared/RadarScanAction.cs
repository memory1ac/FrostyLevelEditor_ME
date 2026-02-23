namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.RadarScanActionData))]
public class RadarScanAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.RadarScanActionData>
{
    public new FrostySdk.Ebx.RadarScanActionData Data => data as FrostySdk.Ebx.RadarScanActionData;
    public override string DisplayName => "RadarScanAction";

    public RadarScanAction(FrostySdk.Ebx.RadarScanActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


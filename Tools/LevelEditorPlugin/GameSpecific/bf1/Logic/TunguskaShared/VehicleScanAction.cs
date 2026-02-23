namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VehicleScanActionData))]
public class VehicleScanAction : RadarScanAction, IEntityData<FrostySdk.Ebx.VehicleScanActionData>
{
    public new FrostySdk.Ebx.VehicleScanActionData Data => data as FrostySdk.Ebx.VehicleScanActionData;
    public override string DisplayName => "VehicleScanAction";

    public VehicleScanAction(FrostySdk.Ebx.VehicleScanActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


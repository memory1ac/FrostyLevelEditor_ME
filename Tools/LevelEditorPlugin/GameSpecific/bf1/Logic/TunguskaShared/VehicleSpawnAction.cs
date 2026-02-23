namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VehicleSpawnActionData))]
public class VehicleSpawnAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.VehicleSpawnActionData>
{
    public new FrostySdk.Ebx.VehicleSpawnActionData Data => data as FrostySdk.Ebx.VehicleSpawnActionData;
    public override string DisplayName => "VehicleSpawnAction";

    public VehicleSpawnAction(FrostySdk.Ebx.VehicleSpawnActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


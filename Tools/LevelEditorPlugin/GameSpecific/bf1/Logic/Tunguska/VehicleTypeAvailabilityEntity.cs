namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VehicleTypeAvailabilityEntityData))]
public class VehicleTypeAvailabilityEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VehicleTypeAvailabilityEntityData>
{
    public new FrostySdk.Ebx.VehicleTypeAvailabilityEntityData Data => data as FrostySdk.Ebx.VehicleTypeAvailabilityEntityData;
    public override string DisplayName => "VehicleTypeAvailability";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public VehicleTypeAvailabilityEntity(FrostySdk.Ebx.VehicleTypeAvailabilityEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


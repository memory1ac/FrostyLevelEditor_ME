namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FindVehicleWeaponInLoadoutSlotDataEntityData))]
public class FindVehicleWeaponInLoadoutSlotDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FindVehicleWeaponInLoadoutSlotDataEntityData>
{
    public new FrostySdk.Ebx.FindVehicleWeaponInLoadoutSlotDataEntityData Data => data as FrostySdk.Ebx.FindVehicleWeaponInLoadoutSlotDataEntityData;
    public override string DisplayName => "FindVehicleWeaponInLoadoutSlotData";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FindVehicleWeaponInLoadoutSlotDataEntity(FrostySdk.Ebx.FindVehicleWeaponInLoadoutSlotDataEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


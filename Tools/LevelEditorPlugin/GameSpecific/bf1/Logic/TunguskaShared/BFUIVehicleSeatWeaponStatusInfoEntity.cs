namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIVehicleSeatWeaponStatusInfoEntityData))]
public class BFUIVehicleSeatWeaponStatusInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIVehicleSeatWeaponStatusInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIVehicleSeatWeaponStatusInfoEntityData Data => data as FrostySdk.Ebx.BFUIVehicleSeatWeaponStatusInfoEntityData;
    public override string DisplayName => "BFUIVehicleSeatWeaponStatusInfo";

    public BFUIVehicleSeatWeaponStatusInfoEntity(FrostySdk.Ebx.BFUIVehicleSeatWeaponStatusInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


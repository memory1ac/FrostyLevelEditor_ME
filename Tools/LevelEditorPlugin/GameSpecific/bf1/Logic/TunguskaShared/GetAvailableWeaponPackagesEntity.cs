namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetAvailableWeaponPackagesEntityData))]
public class GetAvailableWeaponPackagesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GetAvailableWeaponPackagesEntityData>
{
    public new FrostySdk.Ebx.GetAvailableWeaponPackagesEntityData Data => data as FrostySdk.Ebx.GetAvailableWeaponPackagesEntityData;
    public override string DisplayName => "GetAvailableWeaponPackages";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public GetAvailableWeaponPackagesEntity(FrostySdk.Ebx.GetAvailableWeaponPackagesEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


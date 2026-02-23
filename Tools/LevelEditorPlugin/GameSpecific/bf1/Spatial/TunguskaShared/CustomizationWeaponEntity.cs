namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomizationWeaponEntityData))]
public class CustomizationWeaponEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.CustomizationWeaponEntityData>
{
    public new FrostySdk.Ebx.CustomizationWeaponEntityData Data => data as FrostySdk.Ebx.CustomizationWeaponEntityData;
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public CustomizationWeaponEntity(FrostySdk.Ebx.CustomizationWeaponEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


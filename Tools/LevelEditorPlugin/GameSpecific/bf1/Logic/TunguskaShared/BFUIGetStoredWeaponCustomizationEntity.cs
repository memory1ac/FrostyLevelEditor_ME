namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetStoredWeaponCustomizationEntityData))]
public class BFUIGetStoredWeaponCustomizationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetStoredWeaponCustomizationEntityData>
{
    public new FrostySdk.Ebx.BFUIGetStoredWeaponCustomizationEntityData Data => data as FrostySdk.Ebx.BFUIGetStoredWeaponCustomizationEntityData;
    public override string DisplayName => "BFUIGetStoredWeaponCustomization";

    public BFUIGetStoredWeaponCustomizationEntity(FrostySdk.Ebx.BFUIGetStoredWeaponCustomizationEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


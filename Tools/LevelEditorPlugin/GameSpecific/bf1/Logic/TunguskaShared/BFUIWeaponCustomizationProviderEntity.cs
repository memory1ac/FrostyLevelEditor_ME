namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIWeaponCustomizationProviderEntityData))]
public class BFUIWeaponCustomizationProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIWeaponCustomizationProviderEntityData>
{
    public new FrostySdk.Ebx.BFUIWeaponCustomizationProviderEntityData Data => data as FrostySdk.Ebx.BFUIWeaponCustomizationProviderEntityData;
    public override string DisplayName => "BFUIWeaponCustomizationProvider";

    public BFUIWeaponCustomizationProviderEntity(FrostySdk.Ebx.BFUIWeaponCustomizationProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


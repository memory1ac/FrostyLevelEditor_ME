namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIWeaponEntityData))]
public class UIWeaponEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIWeaponEntityData>
{
    public new FrostySdk.Ebx.UIWeaponEntityData Data => data as FrostySdk.Ebx.UIWeaponEntityData;
    public override string DisplayName => "UIWeapon";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIWeaponEntity(FrostySdk.Ebx.UIWeaponEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


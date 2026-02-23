namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIWeaponTargetEntityData))]
public class UIWeaponTargetEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIWeaponTargetEntityData>
{
    public new FrostySdk.Ebx.UIWeaponTargetEntityData Data => data as FrostySdk.Ebx.UIWeaponTargetEntityData;
    public override string DisplayName => "UIWeaponTarget";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIWeaponTargetEntity(FrostySdk.Ebx.UIWeaponTargetEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


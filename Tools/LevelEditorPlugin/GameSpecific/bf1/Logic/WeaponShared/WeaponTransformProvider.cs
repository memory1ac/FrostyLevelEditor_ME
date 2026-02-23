namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WeaponTransformProviderData))]
public class WeaponTransformProvider : LogicEntity, IEntityData<FrostySdk.Ebx.WeaponTransformProviderData>
{
    public new FrostySdk.Ebx.WeaponTransformProviderData Data => data as FrostySdk.Ebx.WeaponTransformProviderData;
    public override string DisplayName => "WeaponTransformProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public WeaponTransformProvider(FrostySdk.Ebx.WeaponTransformProviderData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


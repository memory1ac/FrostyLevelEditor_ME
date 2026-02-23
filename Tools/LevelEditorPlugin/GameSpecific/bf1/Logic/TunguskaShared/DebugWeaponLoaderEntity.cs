namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugWeaponLoaderEntityData))]
public class DebugWeaponLoaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugWeaponLoaderEntityData>
{
    public new FrostySdk.Ebx.DebugWeaponLoaderEntityData Data => data as FrostySdk.Ebx.DebugWeaponLoaderEntityData;
    public override string DisplayName => "DebugWeaponLoader";

    public DebugWeaponLoaderEntity(FrostySdk.Ebx.DebugWeaponLoaderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


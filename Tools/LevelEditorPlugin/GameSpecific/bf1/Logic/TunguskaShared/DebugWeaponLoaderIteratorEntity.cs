namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugWeaponLoaderIteratorEntityData))]
public class DebugWeaponLoaderIteratorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugWeaponLoaderIteratorEntityData>
{
    public new FrostySdk.Ebx.DebugWeaponLoaderIteratorEntityData Data => data as FrostySdk.Ebx.DebugWeaponLoaderIteratorEntityData;
    public override string DisplayName => "DebugWeaponLoaderIterator";

    public DebugWeaponLoaderIteratorEntity(FrostySdk.Ebx.DebugWeaponLoaderIteratorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


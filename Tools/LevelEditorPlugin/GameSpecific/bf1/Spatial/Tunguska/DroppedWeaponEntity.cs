namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DroppedWeaponEntityData))]
public class DroppedWeaponEntity : DroppedItemEntity, IEntityData<FrostySdk.Ebx.DroppedWeaponEntityData>
{
    public new FrostySdk.Ebx.DroppedWeaponEntityData Data => data as FrostySdk.Ebx.DroppedWeaponEntityData;

    public DroppedWeaponEntity(FrostySdk.Ebx.DroppedWeaponEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


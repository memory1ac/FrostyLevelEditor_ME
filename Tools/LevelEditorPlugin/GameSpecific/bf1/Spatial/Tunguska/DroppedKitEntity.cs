namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DroppedKitEntityData))]
public class DroppedKitEntity : DroppedItemEntity, IEntityData<FrostySdk.Ebx.DroppedKitEntityData>
{
    public new FrostySdk.Ebx.DroppedKitEntityData Data => data as FrostySdk.Ebx.DroppedKitEntityData;

    public DroppedKitEntity(FrostySdk.Ebx.DroppedKitEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


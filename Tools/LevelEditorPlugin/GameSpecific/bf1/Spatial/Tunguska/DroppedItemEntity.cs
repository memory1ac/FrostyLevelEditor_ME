namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DroppedItemEntityData))]
public class DroppedItemEntity : GameComponentEntity, IEntityData<FrostySdk.Ebx.DroppedItemEntityData>
{
    public new FrostySdk.Ebx.DroppedItemEntityData Data => data as FrostySdk.Ebx.DroppedItemEntityData;

    public DroppedItemEntity(FrostySdk.Ebx.DroppedItemEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


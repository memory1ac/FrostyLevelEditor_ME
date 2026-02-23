namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.NonStaticCollisionTriggerEntityData))]
public class NonStaticCollisionTriggerEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.NonStaticCollisionTriggerEntityData>
{
    public new FrostySdk.Ebx.NonStaticCollisionTriggerEntityData Data => data as FrostySdk.Ebx.NonStaticCollisionTriggerEntityData;

    public NonStaticCollisionTriggerEntity(FrostySdk.Ebx.NonStaticCollisionTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


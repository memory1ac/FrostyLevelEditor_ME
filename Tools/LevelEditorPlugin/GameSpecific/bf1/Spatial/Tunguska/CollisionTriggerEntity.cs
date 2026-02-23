namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CollisionTriggerEntityData))]
public class CollisionTriggerEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.CollisionTriggerEntityData>
{
    public new FrostySdk.Ebx.CollisionTriggerEntityData Data => data as FrostySdk.Ebx.CollisionTriggerEntityData;

    public CollisionTriggerEntity(FrostySdk.Ebx.CollisionTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


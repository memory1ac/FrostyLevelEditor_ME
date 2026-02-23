namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DamageTriggerEntityData))]
public class DamageTriggerEntity : GamePhysicsEntity, IEntityData<FrostySdk.Ebx.DamageTriggerEntityData>
{
    public new FrostySdk.Ebx.DamageTriggerEntityData Data => data as FrostySdk.Ebx.DamageTriggerEntityData;

    public DamageTriggerEntity(FrostySdk.Ebx.DamageTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


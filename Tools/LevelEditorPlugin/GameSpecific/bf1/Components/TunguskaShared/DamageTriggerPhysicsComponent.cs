
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DamageTriggerPhysicsComponentData))]
public class DamageTriggerPhysicsComponent : GamePhysicsComponent, IEntityData<FrostySdk.Ebx.DamageTriggerPhysicsComponentData>
{
    public new FrostySdk.Ebx.DamageTriggerPhysicsComponentData Data => data as FrostySdk.Ebx.DamageTriggerPhysicsComponentData;
    public override string DisplayName => "DamageTriggerPhysicsComponent";

    public DamageTriggerPhysicsComponent(FrostySdk.Ebx.DamageTriggerPhysicsComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


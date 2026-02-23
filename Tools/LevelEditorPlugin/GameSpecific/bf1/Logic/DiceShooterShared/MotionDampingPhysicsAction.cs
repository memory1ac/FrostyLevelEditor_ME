namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MotionDampingPhysicsActionData))]
public class MotionDampingPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.MotionDampingPhysicsActionData>
{
    public new FrostySdk.Ebx.MotionDampingPhysicsActionData Data => data as FrostySdk.Ebx.MotionDampingPhysicsActionData;
    public override string DisplayName => "MotionDampingPhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public MotionDampingPhysicsAction(FrostySdk.Ebx.MotionDampingPhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


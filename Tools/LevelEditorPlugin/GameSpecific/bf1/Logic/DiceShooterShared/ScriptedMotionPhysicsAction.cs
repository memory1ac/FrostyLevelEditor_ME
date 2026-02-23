namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ScriptedMotionPhysicsActionData))]
public class ScriptedMotionPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.ScriptedMotionPhysicsActionData>
{
    public new FrostySdk.Ebx.ScriptedMotionPhysicsActionData Data => data as FrostySdk.Ebx.ScriptedMotionPhysicsActionData;
    public override string DisplayName => "ScriptedMotionPhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ScriptedMotionPhysicsAction(FrostySdk.Ebx.ScriptedMotionPhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


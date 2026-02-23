namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.GroundFollowPhysicsActionData))]
public class GroundFollowPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.GroundFollowPhysicsActionData>
{
    public new FrostySdk.Ebx.GroundFollowPhysicsActionData Data => data as FrostySdk.Ebx.GroundFollowPhysicsActionData;
    public override string DisplayName => "GroundFollowPhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public GroundFollowPhysicsAction(FrostySdk.Ebx.GroundFollowPhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


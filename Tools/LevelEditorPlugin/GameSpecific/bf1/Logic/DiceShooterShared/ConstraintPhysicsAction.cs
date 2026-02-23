namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ConstraintPhysicsActionData))]
public class ConstraintPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.ConstraintPhysicsActionData>
{
    public new FrostySdk.Ebx.ConstraintPhysicsActionData Data => data as FrostySdk.Ebx.ConstraintPhysicsActionData;
    public override string DisplayName => "ConstraintPhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ConstraintPhysicsAction(FrostySdk.Ebx.ConstraintPhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


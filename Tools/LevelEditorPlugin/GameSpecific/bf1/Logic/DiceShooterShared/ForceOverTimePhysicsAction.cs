namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceOverTimePhysicsActionData))]
public class ForceOverTimePhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.ForceOverTimePhysicsActionData>
{
    public new FrostySdk.Ebx.ForceOverTimePhysicsActionData Data => data as FrostySdk.Ebx.ForceOverTimePhysicsActionData;
    public override string DisplayName => "ForceOverTimePhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ForceOverTimePhysicsAction(FrostySdk.Ebx.ForceOverTimePhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


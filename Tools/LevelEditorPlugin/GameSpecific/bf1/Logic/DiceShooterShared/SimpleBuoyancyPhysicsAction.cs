namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SimpleBuoyancyPhysicsActionData))]
public class SimpleBuoyancyPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.SimpleBuoyancyPhysicsActionData>
{
    public new FrostySdk.Ebx.SimpleBuoyancyPhysicsActionData Data => data as FrostySdk.Ebx.SimpleBuoyancyPhysicsActionData;
    public override string DisplayName => "SimpleBuoyancyPhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SimpleBuoyancyPhysicsAction(FrostySdk.Ebx.SimpleBuoyancyPhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


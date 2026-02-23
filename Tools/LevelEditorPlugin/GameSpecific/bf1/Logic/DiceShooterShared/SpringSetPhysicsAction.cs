namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpringSetPhysicsActionData))]
public class SpringSetPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.SpringSetPhysicsActionData>
{
    public new FrostySdk.Ebx.SpringSetPhysicsActionData Data => data as FrostySdk.Ebx.SpringSetPhysicsActionData;
    public override string DisplayName => "SpringSetPhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SpringSetPhysicsAction(FrostySdk.Ebx.SpringSetPhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


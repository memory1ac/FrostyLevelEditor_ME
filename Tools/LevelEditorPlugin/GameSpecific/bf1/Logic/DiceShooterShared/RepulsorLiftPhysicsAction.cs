namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.RepulsorLiftPhysicsActionData))]
public class RepulsorLiftPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.RepulsorLiftPhysicsActionData>
{
    public new FrostySdk.Ebx.RepulsorLiftPhysicsActionData Data => data as FrostySdk.Ebx.RepulsorLiftPhysicsActionData;
    public override string DisplayName => "RepulsorLiftPhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public RepulsorLiftPhysicsAction(FrostySdk.Ebx.RepulsorLiftPhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


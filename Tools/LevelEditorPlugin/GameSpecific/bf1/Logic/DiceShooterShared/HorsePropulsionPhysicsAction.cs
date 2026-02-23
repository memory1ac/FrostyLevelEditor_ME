namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.HorsePropulsionPhysicsActionData))]
public class HorsePropulsionPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.HorsePropulsionPhysicsActionData>
{
    public new FrostySdk.Ebx.HorsePropulsionPhysicsActionData Data => data as FrostySdk.Ebx.HorsePropulsionPhysicsActionData;
    public override string DisplayName => "HorsePropulsionPhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public HorsePropulsionPhysicsAction(FrostySdk.Ebx.HorsePropulsionPhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


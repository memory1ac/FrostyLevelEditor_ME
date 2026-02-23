namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AltitudeControlPhysicsActionData))]
public class AltitudeControlPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.AltitudeControlPhysicsActionData>
{
    public new FrostySdk.Ebx.AltitudeControlPhysicsActionData Data => data as FrostySdk.Ebx.AltitudeControlPhysicsActionData;
    public override string DisplayName => "AltitudeControlPhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public AltitudeControlPhysicsAction(FrostySdk.Ebx.AltitudeControlPhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpeederBikePhysicsActionData))]
public class SpeederBikePhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.SpeederBikePhysicsActionData>
{
    public new FrostySdk.Ebx.SpeederBikePhysicsActionData Data => data as FrostySdk.Ebx.SpeederBikePhysicsActionData;
    public override string DisplayName => "SpeederBikePhysicsAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SpeederBikePhysicsAction(FrostySdk.Ebx.SpeederBikePhysicsActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


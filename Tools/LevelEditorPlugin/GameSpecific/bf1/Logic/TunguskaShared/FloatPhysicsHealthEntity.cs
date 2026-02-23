namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FloatPhysicsHealthEntityData))]
public class FloatPhysicsHealthEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FloatPhysicsHealthEntityData>
{
    public new FrostySdk.Ebx.FloatPhysicsHealthEntityData Data => data as FrostySdk.Ebx.FloatPhysicsHealthEntityData;
    public override string DisplayName => "FloatPhysicsHealth";

    public FloatPhysicsHealthEntity(FrostySdk.Ebx.FloatPhysicsHealthEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FloatStateActionData))]
public class FloatStateAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.FloatStateActionData>
{
    public new FrostySdk.Ebx.FloatStateActionData Data => data as FrostySdk.Ebx.FloatStateActionData;
    public override string DisplayName => "FloatStateAction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FloatStateAction(FrostySdk.Ebx.FloatStateActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


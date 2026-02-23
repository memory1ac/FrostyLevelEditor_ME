namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FloatFollowEntityData))]
public class FloatFollowEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FloatFollowEntityData>
{
    public new FrostySdk.Ebx.FloatFollowEntityData Data => data as FrostySdk.Ebx.FloatFollowEntityData;
    public override string DisplayName => "FloatFollow";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FloatFollowEntity(FrostySdk.Ebx.FloatFollowEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


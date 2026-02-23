namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIKitRankUpEntityData))]
public class BFUIKitRankUpEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIKitRankUpEntityData>
{
    public new FrostySdk.Ebx.BFUIKitRankUpEntityData Data => data as FrostySdk.Ebx.BFUIKitRankUpEntityData;
    public override string DisplayName => "BFUIKitRankUp";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIKitRankUpEntity(FrostySdk.Ebx.BFUIKitRankUpEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


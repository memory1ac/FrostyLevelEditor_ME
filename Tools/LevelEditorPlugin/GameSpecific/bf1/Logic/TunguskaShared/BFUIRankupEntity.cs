namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIRankupEntityData))]
public class BFUIRankupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIRankupEntityData>
{
    public new FrostySdk.Ebx.BFUIRankupEntityData Data => data as FrostySdk.Ebx.BFUIRankupEntityData;
    public override string DisplayName => "BFUIRankup";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIRankupEntity(FrostySdk.Ebx.BFUIRankupEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


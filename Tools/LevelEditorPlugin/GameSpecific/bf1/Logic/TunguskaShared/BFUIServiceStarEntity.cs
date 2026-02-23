namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIServiceStarEntityData))]
public class BFUIServiceStarEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIServiceStarEntityData>
{
    public new FrostySdk.Ebx.BFUIServiceStarEntityData Data => data as FrostySdk.Ebx.BFUIServiceStarEntityData;
    public override string DisplayName => "BFUIServiceStar";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIServiceStarEntity(FrostySdk.Ebx.BFUIServiceStarEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


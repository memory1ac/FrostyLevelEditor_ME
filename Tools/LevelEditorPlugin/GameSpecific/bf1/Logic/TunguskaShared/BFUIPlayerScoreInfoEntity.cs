namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerScoreInfoEntityData))]
public class BFUIPlayerScoreInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerScoreInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerScoreInfoEntityData Data => data as FrostySdk.Ebx.BFUIPlayerScoreInfoEntityData;
    public override string DisplayName => "BFUIPlayerScoreInfo";

    public BFUIPlayerScoreInfoEntity(FrostySdk.Ebx.BFUIPlayerScoreInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


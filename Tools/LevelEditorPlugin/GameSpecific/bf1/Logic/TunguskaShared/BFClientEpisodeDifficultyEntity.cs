namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFClientEpisodeDifficultyEntityData))]
public class BFClientEpisodeDifficultyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFClientEpisodeDifficultyEntityData>
{
    public new FrostySdk.Ebx.BFClientEpisodeDifficultyEntityData Data => data as FrostySdk.Ebx.BFClientEpisodeDifficultyEntityData;
    public override string DisplayName => "BFClientEpisodeDifficulty";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFClientEpisodeDifficultyEntity(FrostySdk.Ebx.BFClientEpisodeDifficultyEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


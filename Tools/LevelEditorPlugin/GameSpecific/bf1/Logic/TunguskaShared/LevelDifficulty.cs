namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LevelDifficultyData))]
public class LevelDifficulty : LogicEntity, IEntityData<FrostySdk.Ebx.LevelDifficultyData>
{
    public new FrostySdk.Ebx.LevelDifficultyData Data => data as FrostySdk.Ebx.LevelDifficultyData;
    public override string DisplayName => "LevelDifficulty";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public LevelDifficulty(FrostySdk.Ebx.LevelDifficultyData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


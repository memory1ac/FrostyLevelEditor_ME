namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIGameScoringEntityData))]
public class UIGameScoringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIGameScoringEntityData>
{
    public new FrostySdk.Ebx.UIGameScoringEntityData Data => data as FrostySdk.Ebx.UIGameScoringEntityData;
    public override string DisplayName => "UIGameScoring";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIGameScoringEntity(FrostySdk.Ebx.UIGameScoringEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


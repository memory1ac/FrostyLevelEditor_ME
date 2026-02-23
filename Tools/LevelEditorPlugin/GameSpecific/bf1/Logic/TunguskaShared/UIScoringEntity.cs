namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIScoringEntityData))]
public class UIScoringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIScoringEntityData>
{
    public new FrostySdk.Ebx.UIScoringEntityData Data => data as FrostySdk.Ebx.UIScoringEntityData;
    public override string DisplayName => "UIScoring";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIScoringEntity(FrostySdk.Ebx.UIScoringEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


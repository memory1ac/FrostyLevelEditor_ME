namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ScoreSpamTestEntityData))]
public class ScoreSpamTestEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ScoreSpamTestEntityData>
{
    public new FrostySdk.Ebx.ScoreSpamTestEntityData Data => data as FrostySdk.Ebx.ScoreSpamTestEntityData;
    public override string DisplayName => "ScoreSpamTest";

    public ScoreSpamTestEntity(FrostySdk.Ebx.ScoreSpamTestEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


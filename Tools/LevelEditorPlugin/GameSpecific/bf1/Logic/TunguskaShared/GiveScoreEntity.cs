namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.GiveScoreEntityData))]
public class GiveScoreEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GiveScoreEntityData>
{
    public new FrostySdk.Ebx.GiveScoreEntityData Data => data as FrostySdk.Ebx.GiveScoreEntityData;
    public override string DisplayName => "GiveScore";

    public GiveScoreEntity(FrostySdk.Ebx.GiveScoreEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


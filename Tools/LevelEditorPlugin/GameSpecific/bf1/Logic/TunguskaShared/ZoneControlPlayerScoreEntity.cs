namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ZoneControlPlayerScoreEntityData))]
public class ZoneControlPlayerScoreEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ZoneControlPlayerScoreEntityData>
{
    public new FrostySdk.Ebx.ZoneControlPlayerScoreEntityData Data => data as FrostySdk.Ebx.ZoneControlPlayerScoreEntityData;
    public override string DisplayName => "ZoneControlPlayerScore";

    public ZoneControlPlayerScoreEntity(FrostySdk.Ebx.ZoneControlPlayerScoreEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


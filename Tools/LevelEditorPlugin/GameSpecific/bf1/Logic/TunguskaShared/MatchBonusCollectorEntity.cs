namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MatchBonusCollectorEntityData))]
public class MatchBonusCollectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MatchBonusCollectorEntityData>
{
    public new FrostySdk.Ebx.MatchBonusCollectorEntityData Data => data as FrostySdk.Ebx.MatchBonusCollectorEntityData;
    public override string DisplayName => "MatchBonusCollector";

    public MatchBonusCollectorEntity(FrostySdk.Ebx.MatchBonusCollectorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


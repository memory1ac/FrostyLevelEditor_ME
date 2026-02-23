namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FlagScoreCounterEntityData))]
public class FlagScoreCounterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FlagScoreCounterEntityData>
{
    public new FrostySdk.Ebx.FlagScoreCounterEntityData Data => data as FrostySdk.Ebx.FlagScoreCounterEntityData;
    public override string DisplayName => "FlagScoreCounter";

    public FlagScoreCounterEntity(FrostySdk.Ebx.FlagScoreCounterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


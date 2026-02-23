namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.RankGateData))]
public class RankGate : LogicEntity, IEntityData<FrostySdk.Ebx.RankGateData>
{
    public new FrostySdk.Ebx.RankGateData Data => data as FrostySdk.Ebx.RankGateData;
    public override string DisplayName => "RankGate";

    public RankGate(FrostySdk.Ebx.RankGateData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


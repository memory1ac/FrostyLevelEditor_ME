namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFLocalPlayerEventGateData))]
public class BFLocalPlayerEventGate : LogicEntity, IEntityData<FrostySdk.Ebx.BFLocalPlayerEventGateData>
{
    public new FrostySdk.Ebx.BFLocalPlayerEventGateData Data => data as FrostySdk.Ebx.BFLocalPlayerEventGateData;
    public override string DisplayName => "BFLocalPlayerEventGate";

    public BFLocalPlayerEventGate(FrostySdk.Ebx.BFLocalPlayerEventGateData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


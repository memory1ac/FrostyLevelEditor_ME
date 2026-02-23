namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFTimeNudgeBiasEntityData))]
public class BFTimeNudgeBiasEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFTimeNudgeBiasEntityData>
{
    public new FrostySdk.Ebx.BFTimeNudgeBiasEntityData Data => data as FrostySdk.Ebx.BFTimeNudgeBiasEntityData;
    public override string DisplayName => "BFTimeNudgeBias";

    public BFTimeNudgeBiasEntity(FrostySdk.Ebx.BFTimeNudgeBiasEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


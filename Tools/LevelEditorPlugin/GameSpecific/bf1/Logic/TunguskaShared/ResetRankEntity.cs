namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ResetRankEntityData))]
public class ResetRankEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ResetRankEntityData>
{
    public new FrostySdk.Ebx.ResetRankEntityData Data => data as FrostySdk.Ebx.ResetRankEntityData;
    public override string DisplayName => "ResetRank";

    public ResetRankEntity(FrostySdk.Ebx.ResetRankEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


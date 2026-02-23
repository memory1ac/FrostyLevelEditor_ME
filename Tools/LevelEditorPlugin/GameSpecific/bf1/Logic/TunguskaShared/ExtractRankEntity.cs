namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ExtractRankEntityData))]
public class ExtractRankEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ExtractRankEntityData>
{
    public new FrostySdk.Ebx.ExtractRankEntityData Data => data as FrostySdk.Ebx.ExtractRankEntityData;
    public override string DisplayName => "ExtractRank";

    public ExtractRankEntity(FrostySdk.Ebx.ExtractRankEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ArtilleryCrawlingBarrageActionData))]
public class ArtilleryCrawlingBarrageAction : ArtilleryActionBase, IEntityData<FrostySdk.Ebx.ArtilleryCrawlingBarrageActionData>
{
    public new FrostySdk.Ebx.ArtilleryCrawlingBarrageActionData Data => data as FrostySdk.Ebx.ArtilleryCrawlingBarrageActionData;
    public override string DisplayName => "ArtilleryCrawlingBarrageAction";

    public ArtilleryCrawlingBarrageAction(FrostySdk.Ebx.ArtilleryCrawlingBarrageActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ArtillerySuppressionBarrageActionData))]
public class ArtillerySuppressionBarrageAction : ArtilleryActionBase, IEntityData<FrostySdk.Ebx.ArtillerySuppressionBarrageActionData>
{
    public new FrostySdk.Ebx.ArtillerySuppressionBarrageActionData Data => data as FrostySdk.Ebx.ArtillerySuppressionBarrageActionData;
    public override string DisplayName => "ArtillerySuppressionBarrageAction";

    public ArtillerySuppressionBarrageAction(FrostySdk.Ebx.ArtillerySuppressionBarrageActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


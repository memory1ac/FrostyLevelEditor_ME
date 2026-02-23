namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ArtilleryGasBarrageActionData))]
public class ArtilleryGasBarrageAction : ArtilleryActionBase, IEntityData<FrostySdk.Ebx.ArtilleryGasBarrageActionData>
{
    public new FrostySdk.Ebx.ArtilleryGasBarrageActionData Data => data as FrostySdk.Ebx.ArtilleryGasBarrageActionData;
    public override string DisplayName => "ArtilleryGasBarrageAction";

    public ArtilleryGasBarrageAction(FrostySdk.Ebx.ArtilleryGasBarrageActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


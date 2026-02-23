namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ArtilleryPrecisionActionData))]
public class ArtilleryPrecisionAction : ArtilleryActionBase, IEntityData<FrostySdk.Ebx.ArtilleryPrecisionActionData>
{
    public new FrostySdk.Ebx.ArtilleryPrecisionActionData Data => data as FrostySdk.Ebx.ArtilleryPrecisionActionData;
    public override string DisplayName => "ArtilleryPrecisionAction";

    public ArtilleryPrecisionAction(FrostySdk.Ebx.ArtilleryPrecisionActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ArtilleryGroundActionData))]
public class ArtilleryGroundAction : ArtilleryActionBase, IEntityData<FrostySdk.Ebx.ArtilleryGroundActionData>
{
    public new FrostySdk.Ebx.ArtilleryGroundActionData Data => data as FrostySdk.Ebx.ArtilleryGroundActionData;
    public override string DisplayName => "ArtilleryGroundAction";

    public ArtilleryGroundAction(FrostySdk.Ebx.ArtilleryGroundActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


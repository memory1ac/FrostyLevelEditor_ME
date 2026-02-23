namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ArtilleryActionBaseData))]
public class ArtilleryActionBase : CommanderActionBase, IEntityData<FrostySdk.Ebx.ArtilleryActionBaseData>
{
    public new FrostySdk.Ebx.ArtilleryActionBaseData Data => data as FrostySdk.Ebx.ArtilleryActionBaseData;
    public override string DisplayName => "ArtilleryActionBase";

    public ArtilleryActionBase(FrostySdk.Ebx.ArtilleryActionBaseData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


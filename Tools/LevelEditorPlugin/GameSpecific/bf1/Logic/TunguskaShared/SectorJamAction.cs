namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SectorJamActionData))]
public class SectorJamAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.SectorJamActionData>
{
    public new FrostySdk.Ebx.SectorJamActionData Data => data as FrostySdk.Ebx.SectorJamActionData;
    public override string DisplayName => "SectorJamAction";

    public SectorJamAction(FrostySdk.Ebx.SectorJamActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


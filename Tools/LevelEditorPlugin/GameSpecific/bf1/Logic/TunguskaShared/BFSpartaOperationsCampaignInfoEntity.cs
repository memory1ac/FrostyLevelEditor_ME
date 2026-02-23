namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpartaOperationsCampaignInfoEntityData))]
public class BFSpartaOperationsCampaignInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpartaOperationsCampaignInfoEntityData>
{
    public new FrostySdk.Ebx.BFSpartaOperationsCampaignInfoEntityData Data => data as FrostySdk.Ebx.BFSpartaOperationsCampaignInfoEntityData;
    public override string DisplayName => "BFSpartaOperationsCampaignInfo";

    public BFSpartaOperationsCampaignInfoEntity(FrostySdk.Ebx.BFSpartaOperationsCampaignInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


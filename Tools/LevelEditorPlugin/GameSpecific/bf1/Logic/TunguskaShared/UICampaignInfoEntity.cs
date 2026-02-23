namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICampaignInfoEntityData))]
public class UICampaignInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICampaignInfoEntityData>
{
    public new FrostySdk.Ebx.UICampaignInfoEntityData Data => data as FrostySdk.Ebx.UICampaignInfoEntityData;
    public override string DisplayName => "UICampaignInfo";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UICampaignInfoEntity(FrostySdk.Ebx.UICampaignInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


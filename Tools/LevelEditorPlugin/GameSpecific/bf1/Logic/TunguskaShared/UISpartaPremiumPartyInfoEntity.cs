namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISpartaPremiumPartyInfoEntityData))]
public class UISpartaPremiumPartyInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISpartaPremiumPartyInfoEntityData>
{
    public new FrostySdk.Ebx.UISpartaPremiumPartyInfoEntityData Data => data as FrostySdk.Ebx.UISpartaPremiumPartyInfoEntityData;
    public override string DisplayName => "UISpartaPremiumPartyInfo";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISpartaPremiumPartyInfoEntity(FrostySdk.Ebx.UISpartaPremiumPartyInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


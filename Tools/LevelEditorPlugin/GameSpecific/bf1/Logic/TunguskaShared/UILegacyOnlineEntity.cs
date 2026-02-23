namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILegacyOnlineEntityData))]
public class UILegacyOnlineEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILegacyOnlineEntityData>
{
    public new FrostySdk.Ebx.UILegacyOnlineEntityData Data => data as FrostySdk.Ebx.UILegacyOnlineEntityData;
    public override string DisplayName => "UILegacyOnline";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UILegacyOnlineEntity(FrostySdk.Ebx.UILegacyOnlineEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISpartaNotificationProviderEntityData))]
public class UISpartaNotificationProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISpartaNotificationProviderEntityData>
{
    public new FrostySdk.Ebx.UISpartaNotificationProviderEntityData Data => data as FrostySdk.Ebx.UISpartaNotificationProviderEntityData;
    public override string DisplayName => "UISpartaNotificationProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISpartaNotificationProviderEntity(FrostySdk.Ebx.UISpartaNotificationProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


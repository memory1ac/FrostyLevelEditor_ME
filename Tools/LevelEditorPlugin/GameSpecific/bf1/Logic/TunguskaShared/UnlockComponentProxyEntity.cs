namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UnlockComponentProxyEntityData))]
public class UnlockComponentProxyEntity : GameObjectProxyEntity, IEntityData<FrostySdk.Ebx.UnlockComponentProxyEntityData>
{
    public new FrostySdk.Ebx.UnlockComponentProxyEntityData Data => data as FrostySdk.Ebx.UnlockComponentProxyEntityData;
    public override string DisplayName => "UnlockComponentProxy";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UnlockComponentProxyEntity(FrostySdk.Ebx.UnlockComponentProxyEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


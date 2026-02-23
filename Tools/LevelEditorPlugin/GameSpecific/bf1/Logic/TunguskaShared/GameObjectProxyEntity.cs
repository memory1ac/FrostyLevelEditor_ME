namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.GameObjectProxyEntityData))]
public class GameObjectProxyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GameObjectProxyEntityData>
{
    public new FrostySdk.Ebx.GameObjectProxyEntityData Data => data as FrostySdk.Ebx.GameObjectProxyEntityData;
    public override string DisplayName => "GameObjectProxy";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public GameObjectProxyEntity(FrostySdk.Ebx.GameObjectProxyEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


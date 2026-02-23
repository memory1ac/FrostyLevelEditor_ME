namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIMinimapPlayerViewEntityData))]
public class BFUIMinimapPlayerViewEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIMinimapPlayerViewEntityData>
{
    public new FrostySdk.Ebx.BFUIMinimapPlayerViewEntityData Data => data as FrostySdk.Ebx.BFUIMinimapPlayerViewEntityData;
    public override string DisplayName => "BFUIMinimapPlayerView";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIMinimapPlayerViewEntity(FrostySdk.Ebx.BFUIMinimapPlayerViewEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


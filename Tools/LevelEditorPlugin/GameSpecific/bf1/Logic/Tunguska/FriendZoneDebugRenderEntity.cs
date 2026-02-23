namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FriendZoneDebugRenderEntityData))]
public class FriendZoneDebugRenderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FriendZoneDebugRenderEntityData>
{
    public new FrostySdk.Ebx.FriendZoneDebugRenderEntityData Data => data as FrostySdk.Ebx.FriendZoneDebugRenderEntityData;
    public override string DisplayName => "FriendZoneDebugRender";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FriendZoneDebugRenderEntity(FrostySdk.Ebx.FriendZoneDebugRenderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


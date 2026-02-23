namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerAliveFilterEntityData))]
public class PlayerAliveFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerAliveFilterEntityData>
{
    public new FrostySdk.Ebx.PlayerAliveFilterEntityData Data => data as FrostySdk.Ebx.PlayerAliveFilterEntityData;
    public override string DisplayName => "PlayerAliveFilter";

    public PlayerAliveFilterEntity(FrostySdk.Ebx.PlayerAliveFilterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerEventToQueryEntityResultEntityData))]
public class PlayerEventToQueryEntityResultEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerEventToQueryEntityResultEntityData>
{
    public new FrostySdk.Ebx.PlayerEventToQueryEntityResultEntityData Data => data as FrostySdk.Ebx.PlayerEventToQueryEntityResultEntityData;
    public override string DisplayName => "PlayerEventToQueryEntityResult";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public PlayerEventToQueryEntityResultEntity(FrostySdk.Ebx.PlayerEventToQueryEntityResultEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


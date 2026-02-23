namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerHotspotEntityData))]
public class PlayerHotspotEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerHotspotEntityData>
{
    public new FrostySdk.Ebx.PlayerHotspotEntityData Data => data as FrostySdk.Ebx.PlayerHotspotEntityData;
    public override string DisplayName => "PlayerHotspot";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public PlayerHotspotEntity(FrostySdk.Ebx.PlayerHotspotEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


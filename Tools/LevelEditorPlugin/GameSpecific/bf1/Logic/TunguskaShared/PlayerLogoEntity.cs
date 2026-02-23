namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerLogoEntityData))]
public class PlayerLogoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerLogoEntityData>
{
    public new FrostySdk.Ebx.PlayerLogoEntityData Data => data as FrostySdk.Ebx.PlayerLogoEntityData;
    public override string DisplayName => "PlayerLogo";

    public PlayerLogoEntity(FrostySdk.Ebx.PlayerLogoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


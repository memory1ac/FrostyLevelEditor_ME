namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerReadyEntityData))]
public class PlayerReadyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerReadyEntityData>
{
    public new FrostySdk.Ebx.PlayerReadyEntityData Data => data as FrostySdk.Ebx.PlayerReadyEntityData;
    public override string DisplayName => "PlayerReady";

    public PlayerReadyEntity(FrostySdk.Ebx.PlayerReadyEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


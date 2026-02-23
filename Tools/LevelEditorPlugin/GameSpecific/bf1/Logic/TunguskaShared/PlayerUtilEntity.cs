namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerUtilEntityData))]
public class PlayerUtilEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerUtilEntityData>
{
    public new FrostySdk.Ebx.PlayerUtilEntityData Data => data as FrostySdk.Ebx.PlayerUtilEntityData;
    public override string DisplayName => "PlayerUtil";

    public PlayerUtilEntity(FrostySdk.Ebx.PlayerUtilEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


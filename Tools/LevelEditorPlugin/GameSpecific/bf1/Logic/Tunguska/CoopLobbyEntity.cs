namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CoopLobbyEntityData))]
public class CoopLobbyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CoopLobbyEntityData>
{
    public new FrostySdk.Ebx.CoopLobbyEntityData Data => data as FrostySdk.Ebx.CoopLobbyEntityData;
    public override string DisplayName => "CoopLobby";

    public CoopLobbyEntity(FrostySdk.Ebx.CoopLobbyEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


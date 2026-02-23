namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetTeamPlayersEntityData))]
public class BFUIGetTeamPlayersEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetTeamPlayersEntityData>
{
    public new FrostySdk.Ebx.BFUIGetTeamPlayersEntityData Data => data as FrostySdk.Ebx.BFUIGetTeamPlayersEntityData;
    public override string DisplayName => "BFUIGetTeamPlayers";

    public BFUIGetTeamPlayersEntity(FrostySdk.Ebx.BFUIGetTeamPlayersEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


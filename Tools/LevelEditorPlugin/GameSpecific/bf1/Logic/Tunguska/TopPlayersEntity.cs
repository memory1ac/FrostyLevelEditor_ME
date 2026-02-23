namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TopPlayersEntityData))]
public class TopPlayersEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TopPlayersEntityData>
{
    public new FrostySdk.Ebx.TopPlayersEntityData Data => data as FrostySdk.Ebx.TopPlayersEntityData;
    public override string DisplayName => "TopPlayers";

    public TopPlayersEntity(FrostySdk.Ebx.TopPlayersEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


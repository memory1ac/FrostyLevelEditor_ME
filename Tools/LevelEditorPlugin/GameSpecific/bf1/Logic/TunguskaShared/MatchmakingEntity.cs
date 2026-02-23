namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MatchmakingEntityData))]
public class MatchmakingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MatchmakingEntityData>
{
    public new FrostySdk.Ebx.MatchmakingEntityData Data => data as FrostySdk.Ebx.MatchmakingEntityData;
    public override string DisplayName => "Matchmaking";

    public MatchmakingEntity(FrostySdk.Ebx.MatchmakingEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


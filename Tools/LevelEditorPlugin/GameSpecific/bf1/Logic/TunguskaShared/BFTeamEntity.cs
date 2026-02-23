namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFTeamEntityData))]
public class BFTeamEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFTeamEntityData>
{
    public new FrostySdk.Ebx.BFTeamEntityData Data => data as FrostySdk.Ebx.BFTeamEntityData;
    public override string DisplayName => "BFTeam";

    public BFTeamEntity(FrostySdk.Ebx.BFTeamEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


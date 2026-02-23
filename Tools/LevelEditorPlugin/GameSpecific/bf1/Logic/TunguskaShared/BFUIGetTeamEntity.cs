namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetTeamEntityData))]
public class BFUIGetTeamEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetTeamEntityData>
{
    public new FrostySdk.Ebx.BFUIGetTeamEntityData Data => data as FrostySdk.Ebx.BFUIGetTeamEntityData;
    public override string DisplayName => "BFUIGetTeam";

    public BFUIGetTeamEntity(FrostySdk.Ebx.BFUIGetTeamEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


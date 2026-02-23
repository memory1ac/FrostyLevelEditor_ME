namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetTeamSquadsEntityData))]
public class BFUIGetTeamSquadsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetTeamSquadsEntityData>
{
    public new FrostySdk.Ebx.BFUIGetTeamSquadsEntityData Data => data as FrostySdk.Ebx.BFUIGetTeamSquadsEntityData;
    public override string DisplayName => "BFUIGetTeamSquads";

    public BFUIGetTeamSquadsEntity(FrostySdk.Ebx.BFUIGetTeamSquadsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


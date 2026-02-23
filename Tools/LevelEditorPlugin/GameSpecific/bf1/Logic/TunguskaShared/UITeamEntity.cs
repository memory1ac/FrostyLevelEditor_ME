namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UITeamEntityData))]
public class UITeamEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UITeamEntityData>
{
    public new FrostySdk.Ebx.UITeamEntityData Data => data as FrostySdk.Ebx.UITeamEntityData;
    public override string DisplayName => "UITeam";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UITeamEntity(FrostySdk.Ebx.UITeamEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


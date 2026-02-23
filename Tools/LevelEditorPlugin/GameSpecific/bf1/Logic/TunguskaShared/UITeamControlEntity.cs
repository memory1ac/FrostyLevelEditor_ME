namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UITeamControlEntityData))]
public class UITeamControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UITeamControlEntityData>
{
    public new FrostySdk.Ebx.UITeamControlEntityData Data => data as FrostySdk.Ebx.UITeamControlEntityData;
    public override string DisplayName => "UITeamControl";

    public UITeamControlEntity(FrostySdk.Ebx.UITeamControlEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TeamplayEntityData))]
public class TeamplayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TeamplayEntityData>
{
    public new FrostySdk.Ebx.TeamplayEntityData Data => data as FrostySdk.Ebx.TeamplayEntityData;
    public override string DisplayName => "Teamplay";

    public TeamplayEntity(FrostySdk.Ebx.TeamplayEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


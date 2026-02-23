namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SquadVisibilityEntityData))]
public class SquadVisibilityEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SquadVisibilityEntityData>
{
    public new FrostySdk.Ebx.SquadVisibilityEntityData Data => data as FrostySdk.Ebx.SquadVisibilityEntityData;
    public override string DisplayName => "SquadVisibility";

    public SquadVisibilityEntity(FrostySdk.Ebx.SquadVisibilityEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


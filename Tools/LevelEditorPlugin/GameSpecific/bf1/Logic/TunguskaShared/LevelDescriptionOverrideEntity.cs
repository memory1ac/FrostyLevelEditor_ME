namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LevelDescriptionOverrideEntityData))]
public class LevelDescriptionOverrideEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LevelDescriptionOverrideEntityData>
{
    public new FrostySdk.Ebx.LevelDescriptionOverrideEntityData Data => data as FrostySdk.Ebx.LevelDescriptionOverrideEntityData;
    public override string DisplayName => "LevelDescriptionOverride";

    public LevelDescriptionOverrideEntity(FrostySdk.Ebx.LevelDescriptionOverrideEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


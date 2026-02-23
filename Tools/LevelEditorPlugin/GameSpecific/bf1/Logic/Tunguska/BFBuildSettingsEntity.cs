namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFBuildSettingsEntityData))]
public class BFBuildSettingsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFBuildSettingsEntityData>
{
    public new FrostySdk.Ebx.BFBuildSettingsEntityData Data => data as FrostySdk.Ebx.BFBuildSettingsEntityData;
    public override string DisplayName => "BFBuildSettings";

    public BFBuildSettingsEntity(FrostySdk.Ebx.BFBuildSettingsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


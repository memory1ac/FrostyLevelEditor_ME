namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSPIconSettingsEntityData))]
public class BFSPIconSettingsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSPIconSettingsEntityData>
{
    public new FrostySdk.Ebx.BFSPIconSettingsEntityData Data => data as FrostySdk.Ebx.BFSPIconSettingsEntityData;
    public override string DisplayName => "BFSPIconSettings";

    public BFSPIconSettingsEntity(FrostySdk.Ebx.BFSPIconSettingsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


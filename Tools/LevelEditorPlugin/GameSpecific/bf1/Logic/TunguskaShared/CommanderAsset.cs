namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CommanderAssetData))]
public class CommanderAsset : LogicEntity, IEntityData<FrostySdk.Ebx.CommanderAssetData>
{
    public new FrostySdk.Ebx.CommanderAssetData Data => data as FrostySdk.Ebx.CommanderAssetData;
    public override string DisplayName => "CommanderAsset";

    public CommanderAsset(FrostySdk.Ebx.CommanderAssetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


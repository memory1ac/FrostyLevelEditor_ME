namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugUnlockAggregatorEntityData))]
public class DebugUnlockAggregatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugUnlockAggregatorEntityData>
{
    public new FrostySdk.Ebx.DebugUnlockAggregatorEntityData Data => data as FrostySdk.Ebx.DebugUnlockAggregatorEntityData;
    public override string DisplayName => "DebugUnlockAggregator";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public DebugUnlockAggregatorEntity(FrostySdk.Ebx.DebugUnlockAggregatorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


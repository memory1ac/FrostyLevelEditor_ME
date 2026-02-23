namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CheckpointFlagEntityData))]
public class CheckpointFlagEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CheckpointFlagEntityData>
{
    public new FrostySdk.Ebx.CheckpointFlagEntityData Data => data as FrostySdk.Ebx.CheckpointFlagEntityData;
    public override string DisplayName => "CheckpointFlag";

    public CheckpointFlagEntity(FrostySdk.Ebx.CheckpointFlagEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


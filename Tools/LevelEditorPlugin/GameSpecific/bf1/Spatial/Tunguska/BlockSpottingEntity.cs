namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BlockSpottingEntityData))]
public class BlockSpottingEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.BlockSpottingEntityData>
{
    public new FrostySdk.Ebx.BlockSpottingEntityData Data => data as FrostySdk.Ebx.BlockSpottingEntityData;

    public BlockSpottingEntity(FrostySdk.Ebx.BlockSpottingEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFCheckpointEntityData))]
public class BFCheckpointEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.BFCheckpointEntityData>
{
    public new FrostySdk.Ebx.BFCheckpointEntityData Data => data as FrostySdk.Ebx.BFCheckpointEntityData;

    public BFCheckpointEntity(FrostySdk.Ebx.BFCheckpointEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.OcclusionBasedMarkerEntityData))]
public class OcclusionBasedMarkerEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.OcclusionBasedMarkerEntityData>
{
    public new FrostySdk.Ebx.OcclusionBasedMarkerEntityData Data => data as FrostySdk.Ebx.OcclusionBasedMarkerEntityData;

    public OcclusionBasedMarkerEntity(FrostySdk.Ebx.OcclusionBasedMarkerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


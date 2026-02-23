namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFMapMarkerEntityData))]
public class BFMapMarkerEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.BFMapMarkerEntityData>
{
    public new FrostySdk.Ebx.BFMapMarkerEntityData Data => data as FrostySdk.Ebx.BFMapMarkerEntityData;

    public BFMapMarkerEntity(FrostySdk.Ebx.BFMapMarkerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


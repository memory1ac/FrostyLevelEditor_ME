namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TransformFedDummySpatialData))]
public class TransformFedDummySpatial : SpatialEntity, IEntityData<FrostySdk.Ebx.TransformFedDummySpatialData>
{
    public new FrostySdk.Ebx.TransformFedDummySpatialData Data => data as FrostySdk.Ebx.TransformFedDummySpatialData;

    public TransformFedDummySpatial(FrostySdk.Ebx.TransformFedDummySpatialData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


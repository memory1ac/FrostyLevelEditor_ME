namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.OccluderRealPlaneEntityData))]
public class OccluderRealPlaneEntity : OccluderPlaneEntity, IEntityData<FrostySdk.Ebx.OccluderRealPlaneEntityData>
{
    public new FrostySdk.Ebx.OccluderRealPlaneEntityData Data => data as FrostySdk.Ebx.OccluderRealPlaneEntityData;

    public OccluderRealPlaneEntity(FrostySdk.Ebx.OccluderRealPlaneEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


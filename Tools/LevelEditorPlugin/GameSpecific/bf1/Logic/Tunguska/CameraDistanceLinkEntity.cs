namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CameraDistanceLinkEntityData))]
public class CameraDistanceLinkEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CameraDistanceLinkEntityData>
{
    public new FrostySdk.Ebx.CameraDistanceLinkEntityData Data => data as FrostySdk.Ebx.CameraDistanceLinkEntityData;
    public override string DisplayName => "CameraDistanceLink";

    public CameraDistanceLinkEntity(FrostySdk.Ebx.CameraDistanceLinkEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


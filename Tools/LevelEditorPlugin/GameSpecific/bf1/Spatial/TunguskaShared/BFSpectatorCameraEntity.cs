namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpectatorCameraEntityData))]
public class BFSpectatorCameraEntity : CameraEntity, IEntityData<FrostySdk.Ebx.BFSpectatorCameraEntityData>
{
    public new FrostySdk.Ebx.BFSpectatorCameraEntityData Data => data as FrostySdk.Ebx.BFSpectatorCameraEntityData;

    public BFSpectatorCameraEntity(FrostySdk.Ebx.BFSpectatorCameraEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


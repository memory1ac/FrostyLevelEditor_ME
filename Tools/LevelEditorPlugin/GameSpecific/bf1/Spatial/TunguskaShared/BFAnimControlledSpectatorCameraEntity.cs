namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFAnimControlledSpectatorCameraEntityData))]
public class BFAnimControlledSpectatorCameraEntity : BFSpectatorCameraEntity, IEntityData<FrostySdk.Ebx.BFAnimControlledSpectatorCameraEntityData>
{
    public new FrostySdk.Ebx.BFAnimControlledSpectatorCameraEntityData Data => data as FrostySdk.Ebx.BFAnimControlledSpectatorCameraEntityData;

    public BFAnimControlledSpectatorCameraEntity(FrostySdk.Ebx.BFAnimControlledSpectatorCameraEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}



namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierCameraTrackData))]
public class SoldierCameraTrack : CameraTrack, IEntityData<FrostySdk.Ebx.SoldierCameraTrackData>
{
    public new FrostySdk.Ebx.SoldierCameraTrackData Data => data as FrostySdk.Ebx.SoldierCameraTrackData;
    public override string DisplayName => "SoldierCameraTrack";

    public SoldierCameraTrack(FrostySdk.Ebx.SoldierCameraTrackData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


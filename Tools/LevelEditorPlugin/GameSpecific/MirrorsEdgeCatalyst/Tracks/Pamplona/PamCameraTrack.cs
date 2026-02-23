
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCameraTrackData))]
	public class PamCameraTrack : CameraTrack, IEntityData<FrostySdk.Ebx.PamCameraTrackData>
	{
		public new FrostySdk.Ebx.PamCameraTrackData Data => data as FrostySdk.Ebx.PamCameraTrackData;
		public override string DisplayName => "PamCameraTrack";

		public PamCameraTrack(FrostySdk.Ebx.PamCameraTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


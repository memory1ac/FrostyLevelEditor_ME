
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFinisherCameraDirectorTrackData))]
	public class PamFinisherCameraDirectorTrack : CameraDirectorTrack, IEntityData<FrostySdk.Ebx.PamFinisherCameraDirectorTrackData>
	{
		public new FrostySdk.Ebx.PamFinisherCameraDirectorTrackData Data => data as FrostySdk.Ebx.PamFinisherCameraDirectorTrackData;
		public override string DisplayName => "PamFinisherCameraDirectorTrack";

		public PamFinisherCameraDirectorTrack(FrostySdk.Ebx.PamFinisherCameraDirectorTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


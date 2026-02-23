
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamTrackDisablerTrackData))]
	public class PamTrackDisablerTrack : TimelineTrack, IEntityData<FrostySdk.Ebx.PamTrackDisablerTrackData>
	{
		public new FrostySdk.Ebx.PamTrackDisablerTrackData Data => data as FrostySdk.Ebx.PamTrackDisablerTrackData;
		public override string DisplayName => "PamTrackDisablerTrack";

		public PamTrackDisablerTrack(FrostySdk.Ebx.PamTrackDisablerTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


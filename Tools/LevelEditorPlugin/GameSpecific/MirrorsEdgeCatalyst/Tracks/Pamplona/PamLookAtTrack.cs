
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamLookAtTrackData))]
	public class PamLookAtTrack : TimelineTrack, IEntityData<FrostySdk.Ebx.PamLookAtTrackData>
	{
		public new FrostySdk.Ebx.PamLookAtTrackData Data => data as FrostySdk.Ebx.PamLookAtTrackData;
		public override string DisplayName => "PamLookAtTrack";

		public PamLookAtTrack(FrostySdk.Ebx.PamLookAtTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


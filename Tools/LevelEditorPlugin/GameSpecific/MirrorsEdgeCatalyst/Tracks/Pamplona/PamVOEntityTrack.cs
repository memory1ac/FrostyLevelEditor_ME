
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamVOEntityTrackData))]
	public class PamVOEntityTrack : LinkTrack, IEntityData<FrostySdk.Ebx.PamVOEntityTrackData>
	{
		public new FrostySdk.Ebx.PamVOEntityTrackData Data => data as FrostySdk.Ebx.PamVOEntityTrackData;
		public override string DisplayName => "PamVOEntityTrack";

		public PamVOEntityTrack(FrostySdk.Ebx.PamVOEntityTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}



namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FaithProxyTrackData))]
	public class FaithProxyTrack : TemplatedProxyEntityTrack, IEntityData<FrostySdk.Ebx.FaithProxyTrackData>
	{
		public new FrostySdk.Ebx.FaithProxyTrackData Data => data as FrostySdk.Ebx.FaithProxyTrackData;
		public override string DisplayName => "FaithProxyTrack";

		public FaithProxyTrack(FrostySdk.Ebx.FaithProxyTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}



namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StaticModelLayeredTransformTrackData))]
	public class StaticModelLayeredTransformTrack : LayeredTransformTrack, IEntityData<FrostySdk.Ebx.StaticModelLayeredTransformTrackData>
	{
		public new FrostySdk.Ebx.StaticModelLayeredTransformTrackData Data => data as FrostySdk.Ebx.StaticModelLayeredTransformTrackData;
		public override string DisplayName => "StaticModelLayeredTransformTrack";

		public StaticModelLayeredTransformTrack(FrostySdk.Ebx.StaticModelLayeredTransformTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


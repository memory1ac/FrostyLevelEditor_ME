
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DiceTransformTrackData))]
	public class DiceTransformTrack : PropertyTrackBase, IEntityData<FrostySdk.Ebx.DiceTransformTrackData>
	{
		public new FrostySdk.Ebx.DiceTransformTrackData Data => data as FrostySdk.Ebx.DiceTransformTrackData;
		public override string DisplayName => "DiceTransformTrack";

		public DiceTransformTrack(FrostySdk.Ebx.DiceTransformTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


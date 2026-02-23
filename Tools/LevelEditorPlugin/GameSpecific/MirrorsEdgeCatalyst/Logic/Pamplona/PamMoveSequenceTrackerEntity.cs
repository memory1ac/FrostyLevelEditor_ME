using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMoveSequenceTrackerEntityData))]
	public class PamMoveSequenceTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMoveSequenceTrackerEntityData>
	{
		public new FrostySdk.Ebx.PamMoveSequenceTrackerEntityData Data => data as FrostySdk.Ebx.PamMoveSequenceTrackerEntityData;
		public override string DisplayName => "PamMoveSequenceTracker";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamMoveSequenceTrackerEntity(FrostySdk.Ebx.PamMoveSequenceTrackerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMoveTrackerEntityData))]
	public class PamMoveTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMoveTrackerEntityData>
	{
		public new FrostySdk.Ebx.PamMoveTrackerEntityData Data => data as FrostySdk.Ebx.PamMoveTrackerEntityData;
		public override string DisplayName => "PamMoveTracker";

		public PamMoveTrackerEntity(FrostySdk.Ebx.PamMoveTrackerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


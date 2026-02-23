using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamStatUpdateTrackerEntityData))]
	public class PamStatUpdateTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamStatUpdateTrackerEntityData>
	{
		public new FrostySdk.Ebx.PamStatUpdateTrackerEntityData Data => data as FrostySdk.Ebx.PamStatUpdateTrackerEntityData;
		public override string DisplayName => "PamStatUpdateTracker";

		public PamStatUpdateTrackerEntity(FrostySdk.Ebx.PamStatUpdateTrackerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


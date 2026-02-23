using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIControllableTrackerData))]
	public class PamAIControllableTracker : LogicEntity, IEntityData<FrostySdk.Ebx.PamAIControllableTrackerData>
	{
		public new FrostySdk.Ebx.PamAIControllableTrackerData Data => data as FrostySdk.Ebx.PamAIControllableTrackerData;
		public override string DisplayName => "PamAIControllableTracker";

		public PamAIControllableTracker(FrostySdk.Ebx.PamAIControllableTrackerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


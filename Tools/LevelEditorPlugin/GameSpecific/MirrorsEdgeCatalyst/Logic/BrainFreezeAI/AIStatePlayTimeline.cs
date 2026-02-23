using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIStatePlayTimelineData))]
	public class AIStatePlayTimeline : AIState, IEntityData<FrostySdk.Ebx.AIStatePlayTimelineData>
	{
		public new FrostySdk.Ebx.AIStatePlayTimelineData Data => data as FrostySdk.Ebx.AIStatePlayTimelineData;
		public override string DisplayName => "AIStatePlayTimeline";

		public AIStatePlayTimeline(FrostySdk.Ebx.AIStatePlayTimelineData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


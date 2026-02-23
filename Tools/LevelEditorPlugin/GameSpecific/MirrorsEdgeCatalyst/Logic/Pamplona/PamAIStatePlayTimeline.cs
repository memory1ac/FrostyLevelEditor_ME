using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStatePlayTimelineData))]
	public class PamAIStatePlayTimeline : AIStatePlayTimeline, IEntityData<FrostySdk.Ebx.PamAIStatePlayTimelineData>
	{
		public new FrostySdk.Ebx.PamAIStatePlayTimelineData Data => data as FrostySdk.Ebx.PamAIStatePlayTimelineData;
		public override string DisplayName => "PamAIStatePlayTimeline";

		public PamAIStatePlayTimeline(FrostySdk.Ebx.PamAIStatePlayTimelineData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamImpactTimelineEntityData))]
	public class PamImpactTimelineEntity : TimelineEntity, IEntityData<FrostySdk.Ebx.PamImpactTimelineEntityData>
	{
		public new FrostySdk.Ebx.PamImpactTimelineEntityData Data => data as FrostySdk.Ebx.PamImpactTimelineEntityData;
		public override string DisplayName => "PamImpactTimeline";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamImpactTimelineEntity(FrostySdk.Ebx.PamImpactTimelineEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


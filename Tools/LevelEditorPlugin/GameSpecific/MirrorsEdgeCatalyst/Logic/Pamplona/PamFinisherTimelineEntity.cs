using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFinisherTimelineEntityData))]
	public class PamFinisherTimelineEntity : TimelineEntity, IEntityData<FrostySdk.Ebx.PamFinisherTimelineEntityData>
	{
		public new FrostySdk.Ebx.PamFinisherTimelineEntityData Data => data as FrostySdk.Ebx.PamFinisherTimelineEntityData;
		public override string DisplayName => "PamFinisherTimeline";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamFinisherTimelineEntity(FrostySdk.Ebx.PamFinisherTimelineEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


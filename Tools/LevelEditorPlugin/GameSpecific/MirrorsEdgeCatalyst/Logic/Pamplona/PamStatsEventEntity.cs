using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamStatsEventEntityData))]
	public class PamStatsEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamStatsEventEntityData>
	{
		public new FrostySdk.Ebx.PamStatsEventEntityData Data => data as FrostySdk.Ebx.PamStatsEventEntityData;
		public override string DisplayName => "PamStatsEvent";

		public PamStatsEventEntity(FrostySdk.Ebx.PamStatsEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


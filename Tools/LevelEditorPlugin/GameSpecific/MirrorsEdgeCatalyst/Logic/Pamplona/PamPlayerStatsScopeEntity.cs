using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPlayerStatsScopeEntityData))]
	public class PamPlayerStatsScopeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamPlayerStatsScopeEntityData>
	{
		public new FrostySdk.Ebx.PamPlayerStatsScopeEntityData Data => data as FrostySdk.Ebx.PamPlayerStatsScopeEntityData;
		public override string DisplayName => "PamPlayerStatsScope";

		public PamPlayerStatsScopeEntity(FrostySdk.Ebx.PamPlayerStatsScopeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


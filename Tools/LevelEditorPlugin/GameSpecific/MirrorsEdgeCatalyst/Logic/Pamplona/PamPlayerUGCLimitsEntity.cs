using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPlayerUGCLimitsEntityData))]
	public class PamPlayerUGCLimitsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamPlayerUGCLimitsEntityData>
	{
		public new FrostySdk.Ebx.PamPlayerUGCLimitsEntityData Data => data as FrostySdk.Ebx.PamPlayerUGCLimitsEntityData;
		public override string DisplayName => "PamPlayerUGCLimits";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamPlayerUGCLimitsEntity(FrostySdk.Ebx.PamPlayerUGCLimitsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


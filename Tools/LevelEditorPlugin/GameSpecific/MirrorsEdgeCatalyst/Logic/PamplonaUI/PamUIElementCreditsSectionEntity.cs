using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementCreditsSectionEntityData))]
	public class PamUIElementCreditsSectionEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementCreditsSectionEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementCreditsSectionEntityData Data => data as FrostySdk.Ebx.PamUIElementCreditsSectionEntityData;
		public override string DisplayName => "PamUIElementCreditsSection";

		public PamUIElementCreditsSectionEntity(FrostySdk.Ebx.PamUIElementCreditsSectionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


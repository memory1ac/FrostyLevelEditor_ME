using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementMapSelectedIconTooltipEntityData))]
	public class PamUIElementMapSelectedIconTooltipEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementMapSelectedIconTooltipEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementMapSelectedIconTooltipEntityData Data => data as FrostySdk.Ebx.PamUIElementMapSelectedIconTooltipEntityData;
		public override string DisplayName => "PamUIElementMapSelectedIconTooltip";

		public PamUIElementMapSelectedIconTooltipEntity(FrostySdk.Ebx.PamUIElementMapSelectedIconTooltipEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


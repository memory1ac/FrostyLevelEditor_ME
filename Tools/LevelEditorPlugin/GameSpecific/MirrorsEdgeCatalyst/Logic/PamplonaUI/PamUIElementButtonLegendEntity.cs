using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementButtonLegendEntityData))]
	public class PamUIElementButtonLegendEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementButtonLegendEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementButtonLegendEntityData Data => data as FrostySdk.Ebx.PamUIElementButtonLegendEntityData;
		public override string DisplayName => "PamUIElementButtonLegend";

		public PamUIElementButtonLegendEntity(FrostySdk.Ebx.PamUIElementButtonLegendEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


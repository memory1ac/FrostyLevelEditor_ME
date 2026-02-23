using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamWidgetDataFunnelEntityBaseData))]
	public class PamWidgetDataFunnelEntityBase : LogicEntity, IEntityData<FrostySdk.Ebx.PamWidgetDataFunnelEntityBaseData>
	{
		public new FrostySdk.Ebx.PamWidgetDataFunnelEntityBaseData Data => data as FrostySdk.Ebx.PamWidgetDataFunnelEntityBaseData;
		public override string DisplayName => "PamWidgetDataFunnelEntityBase";

		public PamWidgetDataFunnelEntityBase(FrostySdk.Ebx.PamWidgetDataFunnelEntityBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


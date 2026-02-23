using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapTooltipWidgetData))]
	public class PamUIMapTooltipWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIMapTooltipWidgetData>
	{
		public new FrostySdk.Ebx.PamUIMapTooltipWidgetData Data => data as FrostySdk.Ebx.PamUIMapTooltipWidgetData;
		public override string DisplayName => "PamUIMapTooltipWidget";

		public PamUIMapTooltipWidget(FrostySdk.Ebx.PamUIMapTooltipWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


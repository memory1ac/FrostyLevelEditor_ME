using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIScrollPanelWidgetData))]
	public class PamUIScrollPanelWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIScrollPanelWidgetData>
	{
		public new FrostySdk.Ebx.PamUIScrollPanelWidgetData Data => data as FrostySdk.Ebx.PamUIScrollPanelWidgetData;
		public override string DisplayName => "PamUIScrollPanelWidget";

		public PamUIScrollPanelWidget(FrostySdk.Ebx.PamUIScrollPanelWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


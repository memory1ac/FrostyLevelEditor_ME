using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapPanelWidgetData))]
	public class PamUIMapPanelWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIMapPanelWidgetData>
	{
		public new FrostySdk.Ebx.PamUIMapPanelWidgetData Data => data as FrostySdk.Ebx.PamUIMapPanelWidgetData;
		public override string DisplayName => "PamUIMapPanelWidget";

		public PamUIMapPanelWidget(FrostySdk.Ebx.PamUIMapPanelWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


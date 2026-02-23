using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapInfoPanelWidgetData))]
	public class PamUIMapInfoPanelWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIMapInfoPanelWidgetData>
	{
		public new FrostySdk.Ebx.PamUIMapInfoPanelWidgetData Data => data as FrostySdk.Ebx.PamUIMapInfoPanelWidgetData;
		public override string DisplayName => "PamUIMapInfoPanelWidget";

		public PamUIMapInfoPanelWidget(FrostySdk.Ebx.PamUIMapInfoPanelWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


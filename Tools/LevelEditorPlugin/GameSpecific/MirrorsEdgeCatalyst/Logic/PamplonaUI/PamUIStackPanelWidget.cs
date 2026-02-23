using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIStackPanelWidgetData))]
	public class PamUIStackPanelWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIStackPanelWidgetData>
	{
		public new FrostySdk.Ebx.PamUIStackPanelWidgetData Data => data as FrostySdk.Ebx.PamUIStackPanelWidgetData;
		public override string DisplayName => "PamUIStackPanelWidget";

		public PamUIStackPanelWidget(FrostySdk.Ebx.PamUIStackPanelWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


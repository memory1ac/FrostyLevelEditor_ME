using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIWebViewWidgetData))]
	public class PamUIWebViewWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIWebViewWidgetData>
	{
		public new FrostySdk.Ebx.PamUIWebViewWidgetData Data => data as FrostySdk.Ebx.PamUIWebViewWidgetData;
		public override string DisplayName => "PamUIWebViewWidget";

		public PamUIWebViewWidget(FrostySdk.Ebx.PamUIWebViewWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


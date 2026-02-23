using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUISizeTrackingListRowWidgetData))]
	public class PamUISizeTrackingListRowWidget : PamUIListRowWidget, IEntityData<FrostySdk.Ebx.PamUISizeTrackingListRowWidgetData>
	{
		public new FrostySdk.Ebx.PamUISizeTrackingListRowWidgetData Data => data as FrostySdk.Ebx.PamUISizeTrackingListRowWidgetData;
		public override string DisplayName => "PamUISizeTrackingListRowWidget";

		public PamUISizeTrackingListRowWidget(FrostySdk.Ebx.PamUISizeTrackingListRowWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


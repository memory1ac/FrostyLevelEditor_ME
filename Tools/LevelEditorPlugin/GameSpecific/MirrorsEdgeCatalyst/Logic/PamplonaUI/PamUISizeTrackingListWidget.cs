using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUISizeTrackingListWidgetData))]
	public class PamUISizeTrackingListWidget : PamUIListWidget, IEntityData<FrostySdk.Ebx.PamUISizeTrackingListWidgetData>
	{
		public new FrostySdk.Ebx.PamUISizeTrackingListWidgetData Data => data as FrostySdk.Ebx.PamUISizeTrackingListWidgetData;
		public override string DisplayName => "PamUISizeTrackingListWidget";

		public PamUISizeTrackingListWidget(FrostySdk.Ebx.PamUISizeTrackingListWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


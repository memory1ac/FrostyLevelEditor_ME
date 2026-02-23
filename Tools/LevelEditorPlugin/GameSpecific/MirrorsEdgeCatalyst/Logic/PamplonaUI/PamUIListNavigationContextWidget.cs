using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIListNavigationContextWidgetData))]
	public class PamUIListNavigationContextWidget : PamUINavigationContextWidget, IEntityData<FrostySdk.Ebx.PamUIListNavigationContextWidgetData>
	{
		public new FrostySdk.Ebx.PamUIListNavigationContextWidgetData Data => data as FrostySdk.Ebx.PamUIListNavigationContextWidgetData;
		public override string DisplayName => "PamUIListNavigationContextWidget";

		public PamUIListNavigationContextWidget(FrostySdk.Ebx.PamUIListNavigationContextWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIGridNavigationContextWidgetData))]
	public class PamUIGridNavigationContextWidget : PamUINavigationContextWidget, IEntityData<FrostySdk.Ebx.PamUIGridNavigationContextWidgetData>
	{
		public new FrostySdk.Ebx.PamUIGridNavigationContextWidgetData Data => data as FrostySdk.Ebx.PamUIGridNavigationContextWidgetData;
		public override string DisplayName => "PamUIGridNavigationContextWidget";

		public PamUIGridNavigationContextWidget(FrostySdk.Ebx.PamUIGridNavigationContextWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


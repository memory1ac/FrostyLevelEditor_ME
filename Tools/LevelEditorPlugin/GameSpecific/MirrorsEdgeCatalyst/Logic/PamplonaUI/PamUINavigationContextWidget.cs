using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUINavigationContextWidgetData))]
	public class PamUINavigationContextWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUINavigationContextWidgetData>
	{
		public new FrostySdk.Ebx.PamUINavigationContextWidgetData Data => data as FrostySdk.Ebx.PamUINavigationContextWidgetData;
		public override string DisplayName => "PamUINavigationContextWidget";

		public PamUINavigationContextWidget(FrostySdk.Ebx.PamUINavigationContextWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


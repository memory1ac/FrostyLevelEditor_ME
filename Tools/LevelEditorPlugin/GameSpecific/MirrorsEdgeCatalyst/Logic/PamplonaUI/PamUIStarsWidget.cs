using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIStarsWidgetData))]
	public class PamUIStarsWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIStarsWidgetData>
	{
		public new FrostySdk.Ebx.PamUIStarsWidgetData Data => data as FrostySdk.Ebx.PamUIStarsWidgetData;
		public override string DisplayName => "PamUIStarsWidget";

		public PamUIStarsWidget(FrostySdk.Ebx.PamUIStarsWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


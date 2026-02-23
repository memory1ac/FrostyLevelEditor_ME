using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUICellAnimationWidgetData))]
	public class PamUICellAnimationWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUICellAnimationWidgetData>
	{
		public new FrostySdk.Ebx.PamUICellAnimationWidgetData Data => data as FrostySdk.Ebx.PamUICellAnimationWidgetData;
		public override string DisplayName => "PamUICellAnimationWidget";

		public PamUICellAnimationWidget(FrostySdk.Ebx.PamUICellAnimationWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


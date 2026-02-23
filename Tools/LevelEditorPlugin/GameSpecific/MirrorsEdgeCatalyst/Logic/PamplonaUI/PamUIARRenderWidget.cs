using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIARRenderWidgetData))]
	public class PamUIARRenderWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIARRenderWidgetData>
	{
		public new FrostySdk.Ebx.PamUIARRenderWidgetData Data => data as FrostySdk.Ebx.PamUIARRenderWidgetData;
		public override string DisplayName => "PamUIARRenderWidget";

		public PamUIARRenderWidget(FrostySdk.Ebx.PamUIARRenderWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIStencilWidgetData))]
	public class PamUIStencilWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIStencilWidgetData>
	{
		public new FrostySdk.Ebx.PamUIStencilWidgetData Data => data as FrostySdk.Ebx.PamUIStencilWidgetData;
		public override string DisplayName => "PamUIStencilWidget";

		public PamUIStencilWidget(FrostySdk.Ebx.PamUIStencilWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


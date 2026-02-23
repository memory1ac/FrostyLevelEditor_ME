using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapStickyIconWidgetData))]
	public class PamUIMapStickyIconWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIMapStickyIconWidgetData>
	{
		public new FrostySdk.Ebx.PamUIMapStickyIconWidgetData Data => data as FrostySdk.Ebx.PamUIMapStickyIconWidgetData;
		public override string DisplayName => "PamUIMapStickyIconWidget";

		public PamUIMapStickyIconWidget(FrostySdk.Ebx.PamUIMapStickyIconWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


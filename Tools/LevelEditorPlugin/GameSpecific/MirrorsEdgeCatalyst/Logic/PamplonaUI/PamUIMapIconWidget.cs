using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapIconWidgetData))]
	public class PamUIMapIconWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIMapIconWidgetData>
	{
		public new FrostySdk.Ebx.PamUIMapIconWidgetData Data => data as FrostySdk.Ebx.PamUIMapIconWidgetData;
		public override string DisplayName => "PamUIMapIconWidget";

		public PamUIMapIconWidget(FrostySdk.Ebx.PamUIMapIconWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


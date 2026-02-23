using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapIconsWidgetData))]
	public class PamUIMapIconsWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIMapIconsWidgetData>
	{
		public new FrostySdk.Ebx.PamUIMapIconsWidgetData Data => data as FrostySdk.Ebx.PamUIMapIconsWidgetData;
		public override string DisplayName => "PamUIMapIconsWidget";

		public PamUIMapIconsWidget(FrostySdk.Ebx.PamUIMapIconsWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


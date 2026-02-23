using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUICompassWidgetData))]
	public class PamUICompassWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUICompassWidgetData>
	{
		public new FrostySdk.Ebx.PamUICompassWidgetData Data => data as FrostySdk.Ebx.PamUICompassWidgetData;
		public override string DisplayName => "PamUICompassWidget";

		public PamUICompassWidget(FrostySdk.Ebx.PamUICompassWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


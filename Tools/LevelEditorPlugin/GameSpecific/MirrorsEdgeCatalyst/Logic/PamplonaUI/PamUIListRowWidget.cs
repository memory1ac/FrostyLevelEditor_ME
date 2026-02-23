using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIListRowWidgetData))]
	public class PamUIListRowWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIListRowWidgetData>
	{
		public new FrostySdk.Ebx.PamUIListRowWidgetData Data => data as FrostySdk.Ebx.PamUIListRowWidgetData;
		public override string DisplayName => "PamUIListRowWidget";

		public PamUIListRowWidget(FrostySdk.Ebx.PamUIListRowWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


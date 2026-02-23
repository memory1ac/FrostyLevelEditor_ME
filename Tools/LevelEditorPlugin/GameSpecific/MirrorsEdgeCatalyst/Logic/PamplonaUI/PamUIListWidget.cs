using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIListWidgetData))]
	public class PamUIListWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIListWidgetData>
	{
		public new FrostySdk.Ebx.PamUIListWidgetData Data => data as FrostySdk.Ebx.PamUIListWidgetData;
		public override string DisplayName => "PamUIListWidget";

		public PamUIListWidget(FrostySdk.Ebx.PamUIListWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


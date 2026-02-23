using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIBuildInfoWidgetData))]
	public class PamUIBuildInfoWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIBuildInfoWidgetData>
	{
		public new FrostySdk.Ebx.PamUIBuildInfoWidgetData Data => data as FrostySdk.Ebx.PamUIBuildInfoWidgetData;
		public override string DisplayName => "PamUIBuildInfoWidget";

		public PamUIBuildInfoWidget(FrostySdk.Ebx.PamUIBuildInfoWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


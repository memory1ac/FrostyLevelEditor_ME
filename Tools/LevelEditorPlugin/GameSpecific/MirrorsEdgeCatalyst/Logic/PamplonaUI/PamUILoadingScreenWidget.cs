using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUILoadingScreenWidgetData))]
	public class PamUILoadingScreenWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUILoadingScreenWidgetData>
	{
		public new FrostySdk.Ebx.PamUILoadingScreenWidgetData Data => data as FrostySdk.Ebx.PamUILoadingScreenWidgetData;
		public override string DisplayName => "PamUILoadingScreenWidget";

		public PamUILoadingScreenWidget(FrostySdk.Ebx.PamUILoadingScreenWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


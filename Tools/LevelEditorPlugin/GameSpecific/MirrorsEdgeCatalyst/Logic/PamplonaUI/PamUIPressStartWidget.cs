using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIPressStartWidgetData))]
	public class PamUIPressStartWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIPressStartWidgetData>
	{
		public new FrostySdk.Ebx.PamUIPressStartWidgetData Data => data as FrostySdk.Ebx.PamUIPressStartWidgetData;
		public override string DisplayName => "PamUIPressStartWidget";

		public PamUIPressStartWidget(FrostySdk.Ebx.PamUIPressStartWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


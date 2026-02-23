using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIArmWidgetData))]
	public class PamUIArmWidget : PamUIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIArmWidgetData>
	{
		public new FrostySdk.Ebx.PamUIArmWidgetData Data => data as FrostySdk.Ebx.PamUIArmWidgetData;
		public override string DisplayName => "PamUIArmWidget";

		public PamUIArmWidget(FrostySdk.Ebx.PamUIArmWidgetData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


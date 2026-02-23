using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIWidgetEntityData))]
	public class PamUIWidgetEntity : UIWidgetEntity, IEntityData<FrostySdk.Ebx.PamUIWidgetEntityData>
	{
		public new FrostySdk.Ebx.PamUIWidgetEntityData Data => data as FrostySdk.Ebx.PamUIWidgetEntityData;
		public override string DisplayName => "PamUIWidget";

		public PamUIWidgetEntity(FrostySdk.Ebx.PamUIWidgetEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


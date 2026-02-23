using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIArmWidgetReferenceEntityData))]
	public class PamUIArmWidgetReferenceEntity : WidgetReferenceEntity, IEntityData<FrostySdk.Ebx.PamUIArmWidgetReferenceEntityData>
	{
		public new FrostySdk.Ebx.PamUIArmWidgetReferenceEntityData Data => data as FrostySdk.Ebx.PamUIArmWidgetReferenceEntityData;

		public PamUIArmWidgetReferenceEntity(FrostySdk.Ebx.PamUIArmWidgetReferenceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


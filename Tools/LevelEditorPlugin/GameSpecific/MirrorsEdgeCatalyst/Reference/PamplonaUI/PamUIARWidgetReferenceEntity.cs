using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIARWidgetReferenceEntityData))]
	public class PamUIARWidgetReferenceEntity : WidgetReferenceEntity, IEntityData<FrostySdk.Ebx.PamUIARWidgetReferenceEntityData>
	{
		public new FrostySdk.Ebx.PamUIARWidgetReferenceEntityData Data => data as FrostySdk.Ebx.PamUIARWidgetReferenceEntityData;

		public PamUIARWidgetReferenceEntity(FrostySdk.Ebx.PamUIARWidgetReferenceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


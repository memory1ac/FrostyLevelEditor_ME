using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementDynamicWidgetReferenceEntityData))]
	public class PamUIElementDynamicWidgetReferenceEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementDynamicWidgetReferenceEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementDynamicWidgetReferenceEntityData Data => data as FrostySdk.Ebx.PamUIElementDynamicWidgetReferenceEntityData;
		public override string DisplayName => "PamUIElementDynamicWidgetReference";

		public PamUIElementDynamicWidgetReferenceEntity(FrostySdk.Ebx.PamUIElementDynamicWidgetReferenceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


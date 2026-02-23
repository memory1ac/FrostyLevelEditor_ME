using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementSelectableEntityData))]
	public class PamUIElementSelectableEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementSelectableEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementSelectableEntityData Data => data as FrostySdk.Ebx.PamUIElementSelectableEntityData;
		public override string DisplayName => "PamUIElementSelectable";

		public PamUIElementSelectableEntity(FrostySdk.Ebx.PamUIElementSelectableEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIDynamicElementEntityData))]
	public class PamUIDynamicElementEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.PamUIDynamicElementEntityData>
	{
		public new FrostySdk.Ebx.PamUIDynamicElementEntityData Data => data as FrostySdk.Ebx.PamUIDynamicElementEntityData;
		public override string DisplayName => "PamUIDynamicElement";

		public PamUIDynamicElementEntity(FrostySdk.Ebx.PamUIDynamicElementEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


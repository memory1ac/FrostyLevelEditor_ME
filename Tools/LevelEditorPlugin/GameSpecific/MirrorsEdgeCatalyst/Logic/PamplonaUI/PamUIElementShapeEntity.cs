using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementShapeEntityData))]
	public class PamUIElementShapeEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementShapeEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementShapeEntityData Data => data as FrostySdk.Ebx.PamUIElementShapeEntityData;
		public override string DisplayName => "PamUIElementShape";

		public PamUIElementShapeEntity(FrostySdk.Ebx.PamUIElementShapeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


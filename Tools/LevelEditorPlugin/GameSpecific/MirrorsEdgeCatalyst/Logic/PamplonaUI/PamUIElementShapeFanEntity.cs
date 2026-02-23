using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementShapeFanEntityData))]
	public class PamUIElementShapeFanEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementShapeFanEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementShapeFanEntityData Data => data as FrostySdk.Ebx.PamUIElementShapeFanEntityData;
		public override string DisplayName => "PamUIElementShapeFan";

		public PamUIElementShapeFanEntity(FrostySdk.Ebx.PamUIElementShapeFanEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


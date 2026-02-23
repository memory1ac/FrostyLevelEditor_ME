using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementShapeFanProgressEntityData))]
	public class PamUIElementShapeFanProgressEntity : PamUIElementShapeFanEntity, IEntityData<FrostySdk.Ebx.PamUIElementShapeFanProgressEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementShapeFanProgressEntityData Data => data as FrostySdk.Ebx.PamUIElementShapeFanProgressEntityData;
		public override string DisplayName => "PamUIElementShapeFanProgress";

		public PamUIElementShapeFanProgressEntity(FrostySdk.Ebx.PamUIElementShapeFanProgressEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


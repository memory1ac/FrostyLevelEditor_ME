using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMagropeEntityData))]
	public class PamMagropeEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamMagropeEntityData>
	{
		public new FrostySdk.Ebx.PamMagropeEntityData Data => data as FrostySdk.Ebx.PamMagropeEntityData;

		public PamMagropeEntity(FrostySdk.Ebx.PamMagropeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


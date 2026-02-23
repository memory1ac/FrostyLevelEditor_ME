using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCheckpointEntityData))]
	public class PamCheckpointEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamCheckpointEntityData>
	{
		public new FrostySdk.Ebx.PamCheckpointEntityData Data => data as FrostySdk.Ebx.PamCheckpointEntityData;

		public PamCheckpointEntity(FrostySdk.Ebx.PamCheckpointEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


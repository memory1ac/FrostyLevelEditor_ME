using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSpawnLocationEntityData))]
	public class PamSpawnLocationEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamSpawnLocationEntityData>
	{
		public new FrostySdk.Ebx.PamSpawnLocationEntityData Data => data as FrostySdk.Ebx.PamSpawnLocationEntityData;

		public PamSpawnLocationEntity(FrostySdk.Ebx.PamSpawnLocationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


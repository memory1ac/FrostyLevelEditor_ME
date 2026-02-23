using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamDebrisClusterForceEntityData))]
	public class PamDebrisClusterForceEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamDebrisClusterForceEntityData>
	{
		public new FrostySdk.Ebx.PamDebrisClusterForceEntityData Data => data as FrostySdk.Ebx.PamDebrisClusterForceEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamDebrisClusterForceEntity(FrostySdk.Ebx.PamDebrisClusterForceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


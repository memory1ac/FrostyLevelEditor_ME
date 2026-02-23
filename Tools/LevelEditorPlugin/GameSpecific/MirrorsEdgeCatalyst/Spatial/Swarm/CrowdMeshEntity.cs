using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdMeshEntityData))]
	public class CrowdMeshEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.CrowdMeshEntityData>
	{
		public new FrostySdk.Ebx.CrowdMeshEntityData Data => data as FrostySdk.Ebx.CrowdMeshEntityData;

		public CrowdMeshEntity(FrostySdk.Ebx.CrowdMeshEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


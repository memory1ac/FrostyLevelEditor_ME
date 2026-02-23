using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdPlacementPointCloudEntityData))]
	public class CrowdPlacementPointCloudEntity : CrowdPlacementBaseEntity, IEntityData<FrostySdk.Ebx.CrowdPlacementPointCloudEntityData>
	{
		public new FrostySdk.Ebx.CrowdPlacementPointCloudEntityData Data => data as FrostySdk.Ebx.CrowdPlacementPointCloudEntityData;

		public CrowdPlacementPointCloudEntity(FrostySdk.Ebx.CrowdPlacementPointCloudEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


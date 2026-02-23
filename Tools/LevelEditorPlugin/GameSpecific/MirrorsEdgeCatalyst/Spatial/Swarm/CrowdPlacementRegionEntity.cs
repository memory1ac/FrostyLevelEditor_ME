using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdPlacementRegionEntityData))]
	public class CrowdPlacementRegionEntity : CrowdPlacementBaseEntity, IEntityData<FrostySdk.Ebx.CrowdPlacementRegionEntityData>
	{
		public new FrostySdk.Ebx.CrowdPlacementRegionEntityData Data => data as FrostySdk.Ebx.CrowdPlacementRegionEntityData;

		public CrowdPlacementRegionEntity(FrostySdk.Ebx.CrowdPlacementRegionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


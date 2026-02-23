using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdPlacementBaseEntityData))]
	public class CrowdPlacementBaseEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.CrowdPlacementBaseEntityData>
	{
		public new FrostySdk.Ebx.CrowdPlacementBaseEntityData Data => data as FrostySdk.Ebx.CrowdPlacementBaseEntityData;

		public CrowdPlacementBaseEntity(FrostySdk.Ebx.CrowdPlacementBaseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


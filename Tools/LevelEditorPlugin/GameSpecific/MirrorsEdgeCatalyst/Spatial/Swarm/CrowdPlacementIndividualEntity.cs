using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdPlacementIndividualEntityData))]
	public class CrowdPlacementIndividualEntity : CrowdPlacementBaseEntity, IEntityData<FrostySdk.Ebx.CrowdPlacementIndividualEntityData>
	{
		public new FrostySdk.Ebx.CrowdPlacementIndividualEntityData Data => data as FrostySdk.Ebx.CrowdPlacementIndividualEntityData;

		public CrowdPlacementIndividualEntity(FrostySdk.Ebx.CrowdPlacementIndividualEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


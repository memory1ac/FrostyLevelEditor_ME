using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdAttractorRepulsorBaseEntityData))]
	public class CrowdAttractorRepulsorBaseEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.CrowdAttractorRepulsorBaseEntityData>
	{
		public new FrostySdk.Ebx.CrowdAttractorRepulsorBaseEntityData Data => data as FrostySdk.Ebx.CrowdAttractorRepulsorBaseEntityData;

		public CrowdAttractorRepulsorBaseEntity(FrostySdk.Ebx.CrowdAttractorRepulsorBaseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


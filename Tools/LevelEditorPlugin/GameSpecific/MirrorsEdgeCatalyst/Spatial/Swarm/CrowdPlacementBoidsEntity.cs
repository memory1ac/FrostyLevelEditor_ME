using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdPlacementBoidsEntityData))]
	public class CrowdPlacementBoidsEntity : CrowdPlacementBaseEntity, IEntityData<FrostySdk.Ebx.CrowdPlacementBoidsEntityData>
	{
		public new FrostySdk.Ebx.CrowdPlacementBoidsEntityData Data => data as FrostySdk.Ebx.CrowdPlacementBoidsEntityData;

		public CrowdPlacementBoidsEntity(FrostySdk.Ebx.CrowdPlacementBoidsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


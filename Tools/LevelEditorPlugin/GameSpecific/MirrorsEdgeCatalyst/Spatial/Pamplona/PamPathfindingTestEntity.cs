using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPathfindingTestEntityData))]
	public class PamPathfindingTestEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamPathfindingTestEntityData>
	{
		public new FrostySdk.Ebx.PamPathfindingTestEntityData Data => data as FrostySdk.Ebx.PamPathfindingTestEntityData;

		public PamPathfindingTestEntity(FrostySdk.Ebx.PamPathfindingTestEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


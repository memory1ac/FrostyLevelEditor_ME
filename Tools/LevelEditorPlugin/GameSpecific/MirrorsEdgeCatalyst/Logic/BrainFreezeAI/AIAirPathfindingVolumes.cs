using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIAirPathfindingVolumesData))]
	public class AIAirPathfindingVolumes : LogicEntity, IEntityData<FrostySdk.Ebx.AIAirPathfindingVolumesData>
	{
		public new FrostySdk.Ebx.AIAirPathfindingVolumesData Data => data as FrostySdk.Ebx.AIAirPathfindingVolumesData;
		public override string DisplayName => "AIAirPathfindingVolumes";

		public AIAirPathfindingVolumes(FrostySdk.Ebx.AIAirPathfindingVolumesData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


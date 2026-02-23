using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIActionStationCoordinatorData))]
	public class AIActionStationCoordinator : LogicEntity, IEntityData<FrostySdk.Ebx.AIActionStationCoordinatorData>
	{
		public new FrostySdk.Ebx.AIActionStationCoordinatorData Data => data as FrostySdk.Ebx.AIActionStationCoordinatorData;
		public override string DisplayName => "AIActionStationCoordinator";

		public AIActionStationCoordinator(FrostySdk.Ebx.AIActionStationCoordinatorData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


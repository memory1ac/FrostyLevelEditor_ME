using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AICoordinatorData))]
	public class AICoordinator : LogicEntity, IEntityData<FrostySdk.Ebx.AICoordinatorData>
	{
		public new FrostySdk.Ebx.AICoordinatorData Data => data as FrostySdk.Ebx.AICoordinatorData;
		public override string DisplayName => "AICoordinator";

		public AICoordinator(FrostySdk.Ebx.AICoordinatorData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


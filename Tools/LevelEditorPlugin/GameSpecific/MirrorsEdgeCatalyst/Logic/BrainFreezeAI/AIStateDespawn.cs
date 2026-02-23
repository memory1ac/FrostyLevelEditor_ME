using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIStateDespawnData))]
	public class AIStateDespawn : AIState, IEntityData<FrostySdk.Ebx.AIStateDespawnData>
	{
		public new FrostySdk.Ebx.AIStateDespawnData Data => data as FrostySdk.Ebx.AIStateDespawnData;
		public override string DisplayName => "AIStateDespawn";

		public AIStateDespawn(FrostySdk.Ebx.AIStateDespawnData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


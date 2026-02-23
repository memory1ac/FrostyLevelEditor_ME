using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIStateData))]
	public class AIState : AIBehaviourNodeBase, IEntityData<FrostySdk.Ebx.AIStateData>
	{
		public new FrostySdk.Ebx.AIStateData Data => data as FrostySdk.Ebx.AIStateData;
		public override string DisplayName => "AIState";

		public AIState(FrostySdk.Ebx.AIStateData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


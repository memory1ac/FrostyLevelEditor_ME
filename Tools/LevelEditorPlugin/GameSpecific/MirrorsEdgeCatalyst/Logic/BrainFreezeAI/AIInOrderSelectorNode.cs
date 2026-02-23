using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIInOrderSelectorNodeData))]
	public class AIInOrderSelectorNode : AIBehaviourNodeBase, IEntityData<FrostySdk.Ebx.AIInOrderSelectorNodeData>
	{
		public new FrostySdk.Ebx.AIInOrderSelectorNodeData Data => data as FrostySdk.Ebx.AIInOrderSelectorNodeData;
		public override string DisplayName => "AIInOrderSelectorNode";

		public AIInOrderSelectorNode(FrostySdk.Ebx.AIInOrderSelectorNodeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


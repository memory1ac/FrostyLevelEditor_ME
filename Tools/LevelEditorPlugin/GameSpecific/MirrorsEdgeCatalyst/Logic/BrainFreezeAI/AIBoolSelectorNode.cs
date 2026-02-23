using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIBoolSelectorNodeData))]
	public class AIBoolSelectorNode : AIBehaviourNodeBase, IEntityData<FrostySdk.Ebx.AIBoolSelectorNodeData>
	{
		public new FrostySdk.Ebx.AIBoolSelectorNodeData Data => data as FrostySdk.Ebx.AIBoolSelectorNodeData;
		public override string DisplayName => "AIBoolSelectorNode";

		public AIBoolSelectorNode(FrostySdk.Ebx.AIBoolSelectorNodeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


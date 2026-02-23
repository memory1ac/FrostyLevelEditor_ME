using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AILogicSelectorNodeData))]
	public class AILogicSelectorNode : AIBehaviourNodeBase, IEntityData<FrostySdk.Ebx.AILogicSelectorNodeData>
	{
		public new FrostySdk.Ebx.AILogicSelectorNodeData Data => data as FrostySdk.Ebx.AILogicSelectorNodeData;
		public override string DisplayName => "AILogicSelectorNode";

		public AILogicSelectorNode(FrostySdk.Ebx.AILogicSelectorNodeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIOnFitnessSelectorNodeData))]
	public class AIOnFitnessSelectorNode : AIInOrderSelectorNode, IEntityData<FrostySdk.Ebx.AIOnFitnessSelectorNodeData>
	{
		public new FrostySdk.Ebx.AIOnFitnessSelectorNodeData Data => data as FrostySdk.Ebx.AIOnFitnessSelectorNodeData;
		public override string DisplayName => "AIOnFitnessSelectorNode";

		public AIOnFitnessSelectorNode(FrostySdk.Ebx.AIOnFitnessSelectorNodeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


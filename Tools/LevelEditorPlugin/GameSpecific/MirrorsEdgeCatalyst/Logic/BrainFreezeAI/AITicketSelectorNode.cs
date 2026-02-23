using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AITicketSelectorNodeData))]
	public class AITicketSelectorNode : AIBehaviourNodeBase, IEntityData<FrostySdk.Ebx.AITicketSelectorNodeData>
	{
		public new FrostySdk.Ebx.AITicketSelectorNodeData Data => data as FrostySdk.Ebx.AITicketSelectorNodeData;
		public override string DisplayName => "AITicketSelectorNode";

		public AITicketSelectorNode(FrostySdk.Ebx.AITicketSelectorNodeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


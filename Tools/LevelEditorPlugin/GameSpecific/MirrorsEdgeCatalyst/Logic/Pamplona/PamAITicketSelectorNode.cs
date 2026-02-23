using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAITicketSelectorNodeData))]
	public class PamAITicketSelectorNode : AITicketSelectorNode, IEntityData<FrostySdk.Ebx.PamAITicketSelectorNodeData>
	{
		public new FrostySdk.Ebx.PamAITicketSelectorNodeData Data => data as FrostySdk.Ebx.PamAITicketSelectorNodeData;
		public override string DisplayName => "PamAITicketSelectorNode";

		public PamAITicketSelectorNode(FrostySdk.Ebx.PamAITicketSelectorNodeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


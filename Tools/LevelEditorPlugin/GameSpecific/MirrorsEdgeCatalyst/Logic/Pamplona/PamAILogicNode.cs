using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAILogicNodeData))]
	public class PamAILogicNode : AILogicSelectorNode, IEntityData<FrostySdk.Ebx.PamAILogicNodeData>
	{
		public new FrostySdk.Ebx.PamAILogicNodeData Data => data as FrostySdk.Ebx.PamAILogicNodeData;
		public override string DisplayName => "PamAILogicNode";

		public PamAILogicNode(FrostySdk.Ebx.PamAILogicNodeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIPreCheckNodeData))]
	public class PamAIPreCheckNode : AIBehaviourNodeBase, IEntityData<FrostySdk.Ebx.PamAIPreCheckNodeData>
	{
		public new FrostySdk.Ebx.PamAIPreCheckNodeData Data => data as FrostySdk.Ebx.PamAIPreCheckNodeData;
		public override string DisplayName => "PamAIPreCheckNode";

		public PamAIPreCheckNode(FrostySdk.Ebx.PamAIPreCheckNodeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


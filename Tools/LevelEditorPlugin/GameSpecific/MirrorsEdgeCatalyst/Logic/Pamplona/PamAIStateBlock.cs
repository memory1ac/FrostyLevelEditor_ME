using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateBlockData))]
	public class PamAIStateBlock : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateBlockData>
	{
		public new FrostySdk.Ebx.PamAIStateBlockData Data => data as FrostySdk.Ebx.PamAIStateBlockData;
		public override string DisplayName => "PamAIStateBlock";

		public PamAIStateBlock(FrostySdk.Ebx.PamAIStateBlockData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateChaseData))]
	public class PamAIStateChase : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateChaseData>
	{
		public new FrostySdk.Ebx.PamAIStateChaseData Data => data as FrostySdk.Ebx.PamAIStateChaseData;
		public override string DisplayName => "PamAIStateChase";

		public PamAIStateChase(FrostySdk.Ebx.PamAIStateChaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


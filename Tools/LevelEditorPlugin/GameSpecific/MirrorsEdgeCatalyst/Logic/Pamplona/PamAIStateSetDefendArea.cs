using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateSetDefendAreaData))]
	public class PamAIStateSetDefendArea : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateSetDefendAreaData>
	{
		public new FrostySdk.Ebx.PamAIStateSetDefendAreaData Data => data as FrostySdk.Ebx.PamAIStateSetDefendAreaData;
		public override string DisplayName => "PamAIStateSetDefendArea";

		public PamAIStateSetDefendArea(FrostySdk.Ebx.PamAIStateSetDefendAreaData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateDefendAreaData))]
	public class PamAIStateDefendArea : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateDefendAreaData>
	{
		public new FrostySdk.Ebx.PamAIStateDefendAreaData Data => data as FrostySdk.Ebx.PamAIStateDefendAreaData;
		public override string DisplayName => "PamAIStateDefendArea";

		public PamAIStateDefendArea(FrostySdk.Ebx.PamAIStateDefendAreaData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateRepositionDuringMeleeInteractionData))]
	public class PamAIStateRepositionDuringMeleeInteraction : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateRepositionDuringMeleeInteractionData>
	{
		public new FrostySdk.Ebx.PamAIStateRepositionDuringMeleeInteractionData Data => data as FrostySdk.Ebx.PamAIStateRepositionDuringMeleeInteractionData;
		public override string DisplayName => "PamAIStateRepositionDuringMeleeInteraction";

		public PamAIStateRepositionDuringMeleeInteraction(FrostySdk.Ebx.PamAIStateRepositionDuringMeleeInteractionData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


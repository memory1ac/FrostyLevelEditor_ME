using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateInvestigateData))]
	public class PamAIStateInvestigate : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateInvestigateData>
	{
		public new FrostySdk.Ebx.PamAIStateInvestigateData Data => data as FrostySdk.Ebx.PamAIStateInvestigateData;
		public override string DisplayName => "PamAIStateInvestigate";

		public PamAIStateInvestigate(FrostySdk.Ebx.PamAIStateInvestigateData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateDeployData))]
	public class PamAIStateDeploy : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateDeployData>
	{
		public new FrostySdk.Ebx.PamAIStateDeployData Data => data as FrostySdk.Ebx.PamAIStateDeployData;
		public override string DisplayName => "PamAIStateDeploy";

		public PamAIStateDeploy(FrostySdk.Ebx.PamAIStateDeployData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


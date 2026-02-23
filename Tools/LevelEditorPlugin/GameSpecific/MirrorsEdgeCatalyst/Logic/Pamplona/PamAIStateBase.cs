using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateBaseData))]
	public class PamAIStateBase : AIState, IEntityData<FrostySdk.Ebx.PamAIStateBaseData>
	{
		public new FrostySdk.Ebx.PamAIStateBaseData Data => data as FrostySdk.Ebx.PamAIStateBaseData;
		public override string DisplayName => "PamAIStateBase";

		public PamAIStateBase(FrostySdk.Ebx.PamAIStateBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


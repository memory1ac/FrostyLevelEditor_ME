using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateRiotAttackBaseData))]
	public class PamAIStateRiotAttackBase : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateRiotAttackBaseData>
	{
		public new FrostySdk.Ebx.PamAIStateRiotAttackBaseData Data => data as FrostySdk.Ebx.PamAIStateRiotAttackBaseData;
		public override string DisplayName => "PamAIStateRiotAttackBase";

		public PamAIStateRiotAttackBase(FrostySdk.Ebx.PamAIStateRiotAttackBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


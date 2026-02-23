using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateRangedAttackData))]
	public class PamAIStateRangedAttack : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateRangedAttackData>
	{
		public new FrostySdk.Ebx.PamAIStateRangedAttackData Data => data as FrostySdk.Ebx.PamAIStateRangedAttackData;
		public override string DisplayName => "PamAIStateRangedAttack";

		public PamAIStateRangedAttack(FrostySdk.Ebx.PamAIStateRangedAttackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


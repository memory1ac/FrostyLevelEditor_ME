using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateMeleeAttackData))]
	public class PamAIStateMeleeAttack : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateMeleeAttackData>
	{
		public new FrostySdk.Ebx.PamAIStateMeleeAttackData Data => data as FrostySdk.Ebx.PamAIStateMeleeAttackData;
		public override string DisplayName => "PamAIStateMeleeAttack";

		public PamAIStateMeleeAttack(FrostySdk.Ebx.PamAIStateMeleeAttackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


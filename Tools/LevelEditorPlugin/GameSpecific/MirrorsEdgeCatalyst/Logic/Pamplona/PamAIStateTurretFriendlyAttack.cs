using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateTurretFriendlyAttackData))]
	public class PamAIStateTurretFriendlyAttack : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateTurretFriendlyAttackData>
	{
		public new FrostySdk.Ebx.PamAIStateTurretFriendlyAttackData Data => data as FrostySdk.Ebx.PamAIStateTurretFriendlyAttackData;
		public override string DisplayName => "PamAIStateTurretFriendlyAttack";

		public PamAIStateTurretFriendlyAttack(FrostySdk.Ebx.PamAIStateTurretFriendlyAttackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


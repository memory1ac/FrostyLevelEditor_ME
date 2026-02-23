using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateTurretSMGAttackData))]
	public class PamAIStateTurretSMGAttack : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateTurretSMGAttackData>
	{
		public new FrostySdk.Ebx.PamAIStateTurretSMGAttackData Data => data as FrostySdk.Ebx.PamAIStateTurretSMGAttackData;
		public override string DisplayName => "PamAIStateTurretSMGAttack";

		public PamAIStateTurretSMGAttack(FrostySdk.Ebx.PamAIStateTurretSMGAttackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


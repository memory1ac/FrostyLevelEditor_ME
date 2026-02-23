using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateTurretSniperAttackData))]
	public class PamAIStateTurretSniperAttack : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateTurretSniperAttackData>
	{
		public new FrostySdk.Ebx.PamAIStateTurretSniperAttackData Data => data as FrostySdk.Ebx.PamAIStateTurretSniperAttackData;
		public override string DisplayName => "PamAIStateTurretSniperAttack";

		public PamAIStateTurretSniperAttack(FrostySdk.Ebx.PamAIStateTurretSniperAttackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateFixedRiotAttackData))]
	public class PamAIStateFixedRiotAttack : PamAIStateRiotAttackBase, IEntityData<FrostySdk.Ebx.PamAIStateFixedRiotAttackData>
	{
		public new FrostySdk.Ebx.PamAIStateFixedRiotAttackData Data => data as FrostySdk.Ebx.PamAIStateFixedRiotAttackData;
		public override string DisplayName => "PamAIStateFixedRiotAttack";

		public PamAIStateFixedRiotAttack(FrostySdk.Ebx.PamAIStateFixedRiotAttackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


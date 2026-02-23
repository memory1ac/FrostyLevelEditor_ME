using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateDynamicRiotAttackData))]
	public class PamAIStateDynamicRiotAttack : PamAIStateRiotAttackBase, IEntityData<FrostySdk.Ebx.PamAIStateDynamicRiotAttackData>
	{
		public new FrostySdk.Ebx.PamAIStateDynamicRiotAttackData Data => data as FrostySdk.Ebx.PamAIStateDynamicRiotAttackData;
		public override string DisplayName => "PamAIStateDynamicRiotAttack";

		public PamAIStateDynamicRiotAttack(FrostySdk.Ebx.PamAIStateDynamicRiotAttackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


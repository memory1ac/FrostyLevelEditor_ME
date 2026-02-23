using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateHeliAttackData))]
	public class PamAIStateHeliAttack : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateHeliAttackData>
	{
		public new FrostySdk.Ebx.PamAIStateHeliAttackData Data => data as FrostySdk.Ebx.PamAIStateHeliAttackData;
		public override string DisplayName => "PamAIStateHeliAttack";

		public PamAIStateHeliAttack(FrostySdk.Ebx.PamAIStateHeliAttackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


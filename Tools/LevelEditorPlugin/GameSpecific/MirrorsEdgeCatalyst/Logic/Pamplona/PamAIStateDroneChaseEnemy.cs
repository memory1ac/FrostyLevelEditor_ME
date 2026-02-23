using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateDroneChaseEnemyData))]
	public class PamAIStateDroneChaseEnemy : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateDroneChaseEnemyData>
	{
		public new FrostySdk.Ebx.PamAIStateDroneChaseEnemyData Data => data as FrostySdk.Ebx.PamAIStateDroneChaseEnemyData;
		public override string DisplayName => "PamAIStateDroneChaseEnemy";

		public PamAIStateDroneChaseEnemy(FrostySdk.Ebx.PamAIStateDroneChaseEnemyData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


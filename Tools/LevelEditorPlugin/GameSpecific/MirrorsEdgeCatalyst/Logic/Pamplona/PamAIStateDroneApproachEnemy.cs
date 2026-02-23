using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateDroneApproachEnemyData))]
	public class PamAIStateDroneApproachEnemy : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateDroneApproachEnemyData>
	{
		public new FrostySdk.Ebx.PamAIStateDroneApproachEnemyData Data => data as FrostySdk.Ebx.PamAIStateDroneApproachEnemyData;
		public override string DisplayName => "PamAIStateDroneApproachEnemy";

		public PamAIStateDroneApproachEnemy(FrostySdk.Ebx.PamAIStateDroneApproachEnemyData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


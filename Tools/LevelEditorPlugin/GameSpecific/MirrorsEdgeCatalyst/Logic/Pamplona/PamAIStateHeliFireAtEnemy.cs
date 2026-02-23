using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateHeliFireAtEnemyData))]
	public class PamAIStateHeliFireAtEnemy : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateHeliFireAtEnemyData>
	{
		public new FrostySdk.Ebx.PamAIStateHeliFireAtEnemyData Data => data as FrostySdk.Ebx.PamAIStateHeliFireAtEnemyData;
		public override string DisplayName => "PamAIStateHeliFireAtEnemy";

		public PamAIStateHeliFireAtEnemy(FrostySdk.Ebx.PamAIStateHeliFireAtEnemyData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


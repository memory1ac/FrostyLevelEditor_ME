using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIEnemyManagerData))]
	public class AIEnemyManager : AIManagerBase, IEntityData<FrostySdk.Ebx.AIEnemyManagerData>
	{
		public new FrostySdk.Ebx.AIEnemyManagerData Data => data as FrostySdk.Ebx.AIEnemyManagerData;
		public override string DisplayName => "AIEnemyManager";

		public AIEnemyManager(FrostySdk.Ebx.AIEnemyManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


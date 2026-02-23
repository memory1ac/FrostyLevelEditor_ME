using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamEnemyManagerData))]
	public class PamEnemyManager : AIEnemyManager, IEntityData<FrostySdk.Ebx.PamEnemyManagerData>
	{
		public new FrostySdk.Ebx.PamEnemyManagerData Data => data as FrostySdk.Ebx.PamEnemyManagerData;
		public override string DisplayName => "PamEnemyManager";

		public PamEnemyManager(FrostySdk.Ebx.PamEnemyManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


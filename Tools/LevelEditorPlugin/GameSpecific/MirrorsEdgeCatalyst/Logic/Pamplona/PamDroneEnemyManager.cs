using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamDroneEnemyManagerData))]
	public class PamDroneEnemyManager : PamEnemyManager, IEntityData<FrostySdk.Ebx.PamDroneEnemyManagerData>
	{
		public new FrostySdk.Ebx.PamDroneEnemyManagerData Data => data as FrostySdk.Ebx.PamDroneEnemyManagerData;
		public override string DisplayName => "PamDroneEnemyManager";

		public PamDroneEnemyManager(FrostySdk.Ebx.PamDroneEnemyManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


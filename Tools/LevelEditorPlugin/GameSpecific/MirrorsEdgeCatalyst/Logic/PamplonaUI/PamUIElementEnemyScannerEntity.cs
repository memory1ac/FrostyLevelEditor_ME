using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementEnemyScannerEntityData))]
	public class PamUIElementEnemyScannerEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementEnemyScannerEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementEnemyScannerEntityData Data => data as FrostySdk.Ebx.PamUIElementEnemyScannerEntityData;
		public override string DisplayName => "PamUIElementEnemyScanner";

		public PamUIElementEnemyScannerEntity(FrostySdk.Ebx.PamUIElementEnemyScannerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


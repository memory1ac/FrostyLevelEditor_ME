using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementEnemyIndicatorEntityData))]
	public class PamUIElementEnemyIndicatorEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementEnemyIndicatorEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementEnemyIndicatorEntityData Data => data as FrostySdk.Ebx.PamUIElementEnemyIndicatorEntityData;
		public override string DisplayName => "PamUIElementEnemyIndicator";

		public PamUIElementEnemyIndicatorEntity(FrostySdk.Ebx.PamUIElementEnemyIndicatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


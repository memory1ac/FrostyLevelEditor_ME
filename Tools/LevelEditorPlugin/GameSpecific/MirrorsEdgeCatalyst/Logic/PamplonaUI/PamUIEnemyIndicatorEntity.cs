using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIEnemyIndicatorEntityData))]
	public class PamUIEnemyIndicatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIEnemyIndicatorEntityData>
	{
		public new FrostySdk.Ebx.PamUIEnemyIndicatorEntityData Data => data as FrostySdk.Ebx.PamUIEnemyIndicatorEntityData;
		public override string DisplayName => "PamUIEnemyIndicator";

		public PamUIEnemyIndicatorEntity(FrostySdk.Ebx.PamUIEnemyIndicatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


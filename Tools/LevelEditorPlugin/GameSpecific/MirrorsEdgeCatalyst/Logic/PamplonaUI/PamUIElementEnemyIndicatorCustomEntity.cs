using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementEnemyIndicatorCustomEntityData))]
	public class PamUIElementEnemyIndicatorCustomEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementEnemyIndicatorCustomEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementEnemyIndicatorCustomEntityData Data => data as FrostySdk.Ebx.PamUIElementEnemyIndicatorCustomEntityData;
		public override string DisplayName => "PamUIElementEnemyIndicatorCustom";

		public PamUIElementEnemyIndicatorCustomEntity(FrostySdk.Ebx.PamUIElementEnemyIndicatorCustomEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIAutoSpawnCoordinatorData))]
	public class PamAIAutoSpawnCoordinator : LogicEntity, IEntityData<FrostySdk.Ebx.PamAIAutoSpawnCoordinatorData>
	{
		public new FrostySdk.Ebx.PamAIAutoSpawnCoordinatorData Data => data as FrostySdk.Ebx.PamAIAutoSpawnCoordinatorData;
		public override string DisplayName => "PamAIAutoSpawnCoordinator";

		public PamAIAutoSpawnCoordinator(FrostySdk.Ebx.PamAIAutoSpawnCoordinatorData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


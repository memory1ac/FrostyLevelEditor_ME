using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAICoordinatorData))]
	public class PamAICoordinator : AICoordinator, IEntityData<FrostySdk.Ebx.PamAICoordinatorData>
	{
		public new FrostySdk.Ebx.PamAICoordinatorData Data => data as FrostySdk.Ebx.PamAICoordinatorData;
		public override string DisplayName => "PamAICoordinator";

		public PamAICoordinator(FrostySdk.Ebx.PamAICoordinatorData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


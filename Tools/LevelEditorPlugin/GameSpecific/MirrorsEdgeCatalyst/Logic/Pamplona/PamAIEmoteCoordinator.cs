using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIEmoteCoordinatorData))]
	public class PamAIEmoteCoordinator : LogicEntity, IEntityData<FrostySdk.Ebx.PamAIEmoteCoordinatorData>
	{
		public new FrostySdk.Ebx.PamAIEmoteCoordinatorData Data => data as FrostySdk.Ebx.PamAIEmoteCoordinatorData;
		public override string DisplayName => "PamAIEmoteCoordinator";

		public PamAIEmoteCoordinator(FrostySdk.Ebx.PamAIEmoteCoordinatorData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


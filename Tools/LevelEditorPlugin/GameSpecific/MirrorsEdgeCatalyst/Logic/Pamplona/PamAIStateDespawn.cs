using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateDespawnData))]
	public class PamAIStateDespawn : AIStateDespawn, IEntityData<FrostySdk.Ebx.PamAIStateDespawnData>
	{
		public new FrostySdk.Ebx.PamAIStateDespawnData Data => data as FrostySdk.Ebx.PamAIStateDespawnData;
		public override string DisplayName => "PamAIStateDespawn";

		public PamAIStateDespawn(FrostySdk.Ebx.PamAIStateDespawnData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


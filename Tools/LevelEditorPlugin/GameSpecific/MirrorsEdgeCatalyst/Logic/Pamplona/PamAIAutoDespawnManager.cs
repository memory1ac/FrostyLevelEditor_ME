using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIAutoDespawnManagerData))]
	public class PamAIAutoDespawnManager : AIAutoDespawnManager, IEntityData<FrostySdk.Ebx.PamAIAutoDespawnManagerData>
	{
		public new FrostySdk.Ebx.PamAIAutoDespawnManagerData Data => data as FrostySdk.Ebx.PamAIAutoDespawnManagerData;
		public override string DisplayName => "PamAIAutoDespawnManager";

		public PamAIAutoDespawnManager(FrostySdk.Ebx.PamAIAutoDespawnManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


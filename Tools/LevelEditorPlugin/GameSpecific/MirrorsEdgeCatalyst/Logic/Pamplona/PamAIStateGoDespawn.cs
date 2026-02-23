using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateGoDespawnData))]
	public class PamAIStateGoDespawn : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateGoDespawnData>
	{
		public new FrostySdk.Ebx.PamAIStateGoDespawnData Data => data as FrostySdk.Ebx.PamAIStateGoDespawnData;
		public override string DisplayName => "PamAIStateGoDespawn";

		public PamAIStateGoDespawn(FrostySdk.Ebx.PamAIStateGoDespawnData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


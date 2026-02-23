using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateHeliFlyOffAndDespawnData))]
	public class PamAIStateHeliFlyOffAndDespawn : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateHeliFlyOffAndDespawnData>
	{
		public new FrostySdk.Ebx.PamAIStateHeliFlyOffAndDespawnData Data => data as FrostySdk.Ebx.PamAIStateHeliFlyOffAndDespawnData;
		public override string DisplayName => "PamAIStateHeliFlyOffAndDespawn";

		public PamAIStateHeliFlyOffAndDespawn(FrostySdk.Ebx.PamAIStateHeliFlyOffAndDespawnData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


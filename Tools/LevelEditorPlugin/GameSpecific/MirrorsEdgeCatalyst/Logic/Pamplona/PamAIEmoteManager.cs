using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIEmoteManagerData))]
	public class PamAIEmoteManager : AIManagerBase, IEntityData<FrostySdk.Ebx.PamAIEmoteManagerData>
	{
		public new FrostySdk.Ebx.PamAIEmoteManagerData Data => data as FrostySdk.Ebx.PamAIEmoteManagerData;
		public override string DisplayName => "PamAIEmoteManager";

		public PamAIEmoteManager(FrostySdk.Ebx.PamAIEmoteManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


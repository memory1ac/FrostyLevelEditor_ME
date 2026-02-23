using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateSuicideData))]
	public class PamAIStateSuicide : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateSuicideData>
	{
		public new FrostySdk.Ebx.PamAIStateSuicideData Data => data as FrostySdk.Ebx.PamAIStateSuicideData;
		public override string DisplayName => "PamAIStateSuicide";

		public PamAIStateSuicide(FrostySdk.Ebx.PamAIStateSuicideData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


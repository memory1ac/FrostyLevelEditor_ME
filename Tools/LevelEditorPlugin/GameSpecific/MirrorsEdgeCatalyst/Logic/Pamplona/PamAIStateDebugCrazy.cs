using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateDebugCrazyData))]
	public class PamAIStateDebugCrazy : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateDebugCrazyData>
	{
		public new FrostySdk.Ebx.PamAIStateDebugCrazyData Data => data as FrostySdk.Ebx.PamAIStateDebugCrazyData;
		public override string DisplayName => "PamAIStateDebugCrazy";

		public PamAIStateDebugCrazy(FrostySdk.Ebx.PamAIStateDebugCrazyData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


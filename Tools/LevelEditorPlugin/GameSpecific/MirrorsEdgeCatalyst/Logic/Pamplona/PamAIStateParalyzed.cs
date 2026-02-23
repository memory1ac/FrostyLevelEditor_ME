using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateParalyzedData))]
	public class PamAIStateParalyzed : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateParalyzedData>
	{
		public new FrostySdk.Ebx.PamAIStateParalyzedData Data => data as FrostySdk.Ebx.PamAIStateParalyzedData;
		public override string DisplayName => "PamAIStateParalyzed";

		public PamAIStateParalyzed(FrostySdk.Ebx.PamAIStateParalyzedData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


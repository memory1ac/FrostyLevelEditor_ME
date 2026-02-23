using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateFindGoodFiringPosData))]
	public class PamAIStateFindGoodFiringPos : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateFindGoodFiringPosData>
	{
		public new FrostySdk.Ebx.PamAIStateFindGoodFiringPosData Data => data as FrostySdk.Ebx.PamAIStateFindGoodFiringPosData;
		public override string DisplayName => "PamAIStateFindGoodFiringPos";

		public PamAIStateFindGoodFiringPos(FrostySdk.Ebx.PamAIStateFindGoodFiringPosData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


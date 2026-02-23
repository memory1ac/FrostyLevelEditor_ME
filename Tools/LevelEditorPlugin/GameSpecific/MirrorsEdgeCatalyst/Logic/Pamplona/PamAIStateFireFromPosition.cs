using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateFireFromPositionData))]
	public class PamAIStateFireFromPosition : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateFireFromPositionData>
	{
		public new FrostySdk.Ebx.PamAIStateFireFromPositionData Data => data as FrostySdk.Ebx.PamAIStateFireFromPositionData;
		public override string DisplayName => "PamAIStateFireFromPosition";

		public PamAIStateFireFromPosition(FrostySdk.Ebx.PamAIStateFireFromPositionData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


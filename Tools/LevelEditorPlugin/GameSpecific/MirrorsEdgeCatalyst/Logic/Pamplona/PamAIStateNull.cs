using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateNullData))]
	public class PamAIStateNull : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateNullData>
	{
		public new FrostySdk.Ebx.PamAIStateNullData Data => data as FrostySdk.Ebx.PamAIStateNullData;
		public override string DisplayName => "PamAIStateNull";

		public PamAIStateNull(FrostySdk.Ebx.PamAIStateNullData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


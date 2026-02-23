using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateBackOffData))]
	public class PamAIStateBackOff : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateBackOffData>
	{
		public new FrostySdk.Ebx.PamAIStateBackOffData Data => data as FrostySdk.Ebx.PamAIStateBackOffData;
		public override string DisplayName => "PamAIStateBackOff";

		public PamAIStateBackOff(FrostySdk.Ebx.PamAIStateBackOffData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


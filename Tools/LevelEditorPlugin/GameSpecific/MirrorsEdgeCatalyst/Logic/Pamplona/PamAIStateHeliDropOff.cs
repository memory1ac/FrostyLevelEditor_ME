using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateHeliDropOffData))]
	public class PamAIStateHeliDropOff : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateHeliDropOffData>
	{
		public new FrostySdk.Ebx.PamAIStateHeliDropOffData Data => data as FrostySdk.Ebx.PamAIStateHeliDropOffData;
		public override string DisplayName => "PamAIStateHeliDropOff";

		public PamAIStateHeliDropOff(FrostySdk.Ebx.PamAIStateHeliDropOffData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


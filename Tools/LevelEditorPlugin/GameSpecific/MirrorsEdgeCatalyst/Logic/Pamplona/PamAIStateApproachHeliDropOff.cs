using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateApproachHeliDropOffData))]
	public class PamAIStateApproachHeliDropOff : AIStateExecuteActionStation, IEntityData<FrostySdk.Ebx.PamAIStateApproachHeliDropOffData>
	{
		public new FrostySdk.Ebx.PamAIStateApproachHeliDropOffData Data => data as FrostySdk.Ebx.PamAIStateApproachHeliDropOffData;
		public override string DisplayName => "PamAIStateApproachHeliDropOff";

		public PamAIStateApproachHeliDropOff(FrostySdk.Ebx.PamAIStateApproachHeliDropOffData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIStateExecuteActionStationData))]
	public class AIStateExecuteActionStation : AIState, IEntityData<FrostySdk.Ebx.AIStateExecuteActionStationData>
	{
		public new FrostySdk.Ebx.AIStateExecuteActionStationData Data => data as FrostySdk.Ebx.AIStateExecuteActionStationData;
		public override string DisplayName => "AIStateExecuteActionStation";

		public AIStateExecuteActionStation(FrostySdk.Ebx.AIStateExecuteActionStationData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


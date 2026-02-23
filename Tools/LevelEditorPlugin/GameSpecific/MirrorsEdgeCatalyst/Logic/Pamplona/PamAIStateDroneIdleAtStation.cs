using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateDroneIdleAtStationData))]
	public class PamAIStateDroneIdleAtStation : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateDroneIdleAtStationData>
	{
		public new FrostySdk.Ebx.PamAIStateDroneIdleAtStationData Data => data as FrostySdk.Ebx.PamAIStateDroneIdleAtStationData;
		public override string DisplayName => "PamAIStateDroneIdleAtStation";

		public PamAIStateDroneIdleAtStation(FrostySdk.Ebx.PamAIStateDroneIdleAtStationData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


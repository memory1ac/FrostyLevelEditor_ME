using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateDronePatrolData))]
	public class PamAIStateDronePatrol : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateDronePatrolData>
	{
		public new FrostySdk.Ebx.PamAIStateDronePatrolData Data => data as FrostySdk.Ebx.PamAIStateDronePatrolData;
		public override string DisplayName => "PamAIStateDronePatrol";

		public PamAIStateDronePatrol(FrostySdk.Ebx.PamAIStateDronePatrolData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


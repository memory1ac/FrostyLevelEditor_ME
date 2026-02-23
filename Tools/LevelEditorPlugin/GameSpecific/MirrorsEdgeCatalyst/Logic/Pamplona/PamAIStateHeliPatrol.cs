using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateHeliPatrolData))]
	public class PamAIStateHeliPatrol : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateHeliPatrolData>
	{
		public new FrostySdk.Ebx.PamAIStateHeliPatrolData Data => data as FrostySdk.Ebx.PamAIStateHeliPatrolData;
		public override string DisplayName => "PamAIStateHeliPatrol";

		public PamAIStateHeliPatrol(FrostySdk.Ebx.PamAIStateHeliPatrolData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


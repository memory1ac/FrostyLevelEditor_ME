using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSyncedStateMachineEntityData))]
	public class PamSyncedStateMachineEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSyncedStateMachineEntityData>
	{
		public new FrostySdk.Ebx.PamSyncedStateMachineEntityData Data => data as FrostySdk.Ebx.PamSyncedStateMachineEntityData;
		public override string DisplayName => "PamSyncedStateMachine";

		public PamSyncedStateMachineEntity(FrostySdk.Ebx.PamSyncedStateMachineEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


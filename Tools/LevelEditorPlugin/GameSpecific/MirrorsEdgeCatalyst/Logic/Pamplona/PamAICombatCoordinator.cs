using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAICombatCoordinatorData))]
	public class PamAICombatCoordinator : LogicEntity, IEntityData<FrostySdk.Ebx.PamAICombatCoordinatorData>
	{
		public new FrostySdk.Ebx.PamAICombatCoordinatorData Data => data as FrostySdk.Ebx.PamAICombatCoordinatorData;
		public override string DisplayName => "PamAICombatCoordinator";

		public PamAICombatCoordinator(FrostySdk.Ebx.PamAICombatCoordinatorData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


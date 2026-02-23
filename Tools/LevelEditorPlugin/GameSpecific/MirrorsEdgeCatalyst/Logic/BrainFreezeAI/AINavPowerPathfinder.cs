using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AINavPowerPathfinderData))]
	public class AINavPowerPathfinder : AIPathfinder, IEntityData<FrostySdk.Ebx.AINavPowerPathfinderData>
	{
		public new FrostySdk.Ebx.AINavPowerPathfinderData Data => data as FrostySdk.Ebx.AINavPowerPathfinderData;
		public override string DisplayName => "AINavPowerPathfinder";

		public AINavPowerPathfinder(FrostySdk.Ebx.AINavPowerPathfinderData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


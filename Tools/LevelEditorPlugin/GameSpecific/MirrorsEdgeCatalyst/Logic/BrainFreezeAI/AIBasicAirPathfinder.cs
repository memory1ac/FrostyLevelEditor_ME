using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIBasicAirPathfinderData))]
	public class AIBasicAirPathfinder : AIPathfinder, IEntityData<FrostySdk.Ebx.AIBasicAirPathfinderData>
	{
		public new FrostySdk.Ebx.AIBasicAirPathfinderData Data => data as FrostySdk.Ebx.AIBasicAirPathfinderData;
		public override string DisplayName => "AIBasicAirPathfinder";

		public AIBasicAirPathfinder(FrostySdk.Ebx.AIBasicAirPathfinderData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


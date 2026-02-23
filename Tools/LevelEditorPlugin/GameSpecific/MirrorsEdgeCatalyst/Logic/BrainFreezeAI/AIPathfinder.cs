using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIPathfinderData))]
	public class AIPathfinder : LogicEntity, IEntityData<FrostySdk.Ebx.AIPathfinderData>
	{
		public new FrostySdk.Ebx.AIPathfinderData Data => data as FrostySdk.Ebx.AIPathfinderData;
		public override string DisplayName => "AIPathfinder";

		public AIPathfinder(FrostySdk.Ebx.AIPathfinderData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


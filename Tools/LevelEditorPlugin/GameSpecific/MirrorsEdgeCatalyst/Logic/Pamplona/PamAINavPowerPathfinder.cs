using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAINavPowerPathfinderData))]
	public class PamAINavPowerPathfinder : AINavPowerPathfinder, IEntityData<FrostySdk.Ebx.PamAINavPowerPathfinderData>
	{
		public new FrostySdk.Ebx.PamAINavPowerPathfinderData Data => data as FrostySdk.Ebx.PamAINavPowerPathfinderData;
		public override string DisplayName => "PamAINavPowerPathfinder";

		public PamAINavPowerPathfinder(FrostySdk.Ebx.PamAINavPowerPathfinderData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


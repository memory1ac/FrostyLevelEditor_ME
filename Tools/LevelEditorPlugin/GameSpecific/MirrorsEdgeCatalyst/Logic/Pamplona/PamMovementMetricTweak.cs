using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMovementMetricTweakData))]
	public class PamMovementMetricTweak : LogicEntity, IEntityData<FrostySdk.Ebx.PamMovementMetricTweakData>
	{
		public new FrostySdk.Ebx.PamMovementMetricTweakData Data => data as FrostySdk.Ebx.PamMovementMetricTweakData;
		public override string DisplayName => "PamMovementMetricTweak";

		public PamMovementMetricTweak(FrostySdk.Ebx.PamMovementMetricTweakData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


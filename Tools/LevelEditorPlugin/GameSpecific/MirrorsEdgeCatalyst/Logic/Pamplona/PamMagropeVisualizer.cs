using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMagropeVisualizerData))]
	public class PamMagropeVisualizer : LogicEntity, IEntityData<FrostySdk.Ebx.PamMagropeVisualizerData>
	{
		public new FrostySdk.Ebx.PamMagropeVisualizerData Data => data as FrostySdk.Ebx.PamMagropeVisualizerData;
		public override string DisplayName => "PamMagropeVisualizer";

		public PamMagropeVisualizer(FrostySdk.Ebx.PamMagropeVisualizerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


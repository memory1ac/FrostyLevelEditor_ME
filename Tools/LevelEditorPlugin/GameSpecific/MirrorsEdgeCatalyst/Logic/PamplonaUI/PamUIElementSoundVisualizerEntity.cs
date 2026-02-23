using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementSoundVisualizerEntityData))]
	public class PamUIElementSoundVisualizerEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementSoundVisualizerEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementSoundVisualizerEntityData Data => data as FrostySdk.Ebx.PamUIElementSoundVisualizerEntityData;
		public override string DisplayName => "PamUIElementSoundVisualizer";

		public PamUIElementSoundVisualizerEntity(FrostySdk.Ebx.PamUIElementSoundVisualizerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamReplayEntityData))]
	public class PamReplayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamReplayEntityData>
	{
		public new FrostySdk.Ebx.PamReplayEntityData Data => data as FrostySdk.Ebx.PamReplayEntityData;
		public override string DisplayName => "PamReplay";

		public PamReplayEntity(FrostySdk.Ebx.PamReplayEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


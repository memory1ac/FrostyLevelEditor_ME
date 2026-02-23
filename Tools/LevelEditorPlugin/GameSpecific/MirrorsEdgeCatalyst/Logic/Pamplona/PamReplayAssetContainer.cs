using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamReplayAssetContainerData))]
	public class PamReplayAssetContainer : LogicEntity, IEntityData<FrostySdk.Ebx.PamReplayAssetContainerData>
	{
		public new FrostySdk.Ebx.PamReplayAssetContainerData Data => data as FrostySdk.Ebx.PamReplayAssetContainerData;
		public override string DisplayName => "PamReplayAssetContainer";

		public PamReplayAssetContainer(FrostySdk.Ebx.PamReplayAssetContainerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


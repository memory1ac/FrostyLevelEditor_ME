using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamNavigationMasterData))]
	public class PamNavigationMaster : SpatialEntity, IEntityData<FrostySdk.Ebx.PamNavigationMasterData>
	{
		public new FrostySdk.Ebx.PamNavigationMasterData Data => data as FrostySdk.Ebx.PamNavigationMasterData;

		public PamNavigationMaster(FrostySdk.Ebx.PamNavigationMasterData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


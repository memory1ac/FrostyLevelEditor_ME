using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamNavigationMapHistoryData))]
	public class PamNavigationMapHistory : SpatialEntity, IEntityData<FrostySdk.Ebx.PamNavigationMapHistoryData>
	{
		public new FrostySdk.Ebx.PamNavigationMapHistoryData Data => data as FrostySdk.Ebx.PamNavigationMapHistoryData;

		public PamNavigationMapHistory(FrostySdk.Ebx.PamNavigationMapHistoryData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIHotspotHeliActionStationData))]
	public class PamAIHotspotHeliActionStation : ActionStation, IEntityData<FrostySdk.Ebx.PamAIHotspotHeliActionStationData>
	{
		public new FrostySdk.Ebx.PamAIHotspotHeliActionStationData Data => data as FrostySdk.Ebx.PamAIHotspotHeliActionStationData;

		public PamAIHotspotHeliActionStation(FrostySdk.Ebx.PamAIHotspotHeliActionStationData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


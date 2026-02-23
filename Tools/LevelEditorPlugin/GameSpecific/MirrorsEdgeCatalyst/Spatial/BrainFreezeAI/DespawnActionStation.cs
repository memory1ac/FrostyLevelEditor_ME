using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DespawnActionStationData))]
	public class DespawnActionStation : ActionStation, IEntityData<FrostySdk.Ebx.DespawnActionStationData>
	{
		public new FrostySdk.Ebx.DespawnActionStationData Data => data as FrostySdk.Ebx.DespawnActionStationData;

		public DespawnActionStation(FrostySdk.Ebx.DespawnActionStationData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


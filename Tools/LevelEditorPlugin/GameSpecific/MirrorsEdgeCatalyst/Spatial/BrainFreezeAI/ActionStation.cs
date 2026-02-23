using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ActionStationData))]
	public class ActionStation : SpatialEntity, IEntityData<FrostySdk.Ebx.ActionStationData>
	{
		public new FrostySdk.Ebx.ActionStationData Data => data as FrostySdk.Ebx.ActionStationData;

		public ActionStation(FrostySdk.Ebx.ActionStationData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


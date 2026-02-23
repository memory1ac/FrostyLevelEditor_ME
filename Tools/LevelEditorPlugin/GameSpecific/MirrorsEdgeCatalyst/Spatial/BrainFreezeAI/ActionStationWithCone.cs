using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ActionStationWithConeData))]
	public class ActionStationWithCone : ActionStation, IEntityData<FrostySdk.Ebx.ActionStationWithConeData>
	{
		public new FrostySdk.Ebx.ActionStationWithConeData Data => data as FrostySdk.Ebx.ActionStationWithConeData;

		public ActionStationWithCone(FrostySdk.Ebx.ActionStationWithConeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


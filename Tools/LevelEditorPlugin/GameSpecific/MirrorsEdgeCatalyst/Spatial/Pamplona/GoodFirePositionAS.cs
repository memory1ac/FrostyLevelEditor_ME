using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GoodFirePositionASData))]
	public class GoodFirePositionAS : ActionStationWithCone, IEntityData<FrostySdk.Ebx.GoodFirePositionASData>
	{
		public new FrostySdk.Ebx.GoodFirePositionASData Data => data as FrostySdk.Ebx.GoodFirePositionASData;

		public GoodFirePositionAS(FrostySdk.Ebx.GoodFirePositionASData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


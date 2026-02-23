using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HeliDropOffASData))]
	public class HeliDropOffAS : ActionStation, IEntityData<FrostySdk.Ebx.HeliDropOffASData>
	{
		public new FrostySdk.Ebx.HeliDropOffASData Data => data as FrostySdk.Ebx.HeliDropOffASData;

		public HeliDropOffAS(FrostySdk.Ebx.HeliDropOffASData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


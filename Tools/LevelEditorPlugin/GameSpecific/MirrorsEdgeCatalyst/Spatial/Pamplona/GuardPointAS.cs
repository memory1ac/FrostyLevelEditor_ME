using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GuardPointASData))]
	public class GuardPointAS : ActionStation, IEntityData<FrostySdk.Ebx.GuardPointASData>
	{
		public new FrostySdk.Ebx.GuardPointASData Data => data as FrostySdk.Ebx.GuardPointASData;

		public GuardPointAS(FrostySdk.Ebx.GuardPointASData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


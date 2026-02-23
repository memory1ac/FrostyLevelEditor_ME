using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProgressionFlagGroupEntityData))]
	public class PamProgressionFlagGroupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProgressionFlagGroupEntityData>
	{
		public new FrostySdk.Ebx.PamProgressionFlagGroupEntityData Data => data as FrostySdk.Ebx.PamProgressionFlagGroupEntityData;
		public override string DisplayName => "PamProgressionFlagGroup";

		public PamProgressionFlagGroupEntity(FrostySdk.Ebx.PamProgressionFlagGroupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


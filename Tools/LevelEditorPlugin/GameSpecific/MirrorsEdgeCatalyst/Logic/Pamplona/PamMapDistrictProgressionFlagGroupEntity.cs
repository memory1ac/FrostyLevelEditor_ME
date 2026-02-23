using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapDistrictProgressionFlagGroupEntityData))]
	public class PamMapDistrictProgressionFlagGroupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapDistrictProgressionFlagGroupEntityData>
	{
		public new FrostySdk.Ebx.PamMapDistrictProgressionFlagGroupEntityData Data => data as FrostySdk.Ebx.PamMapDistrictProgressionFlagGroupEntityData;
		public override string DisplayName => "PamMapDistrictProgressionFlagGroup";

		public PamMapDistrictProgressionFlagGroupEntity(FrostySdk.Ebx.PamMapDistrictProgressionFlagGroupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


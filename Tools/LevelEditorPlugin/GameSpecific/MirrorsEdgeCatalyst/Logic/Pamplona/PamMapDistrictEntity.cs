using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapDistrictEntityData))]
	public class PamMapDistrictEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapDistrictEntityData>
	{
		public new FrostySdk.Ebx.PamMapDistrictEntityData Data => data as FrostySdk.Ebx.PamMapDistrictEntityData;
		public override string DisplayName => "PamMapDistrict";

		public PamMapDistrictEntity(FrostySdk.Ebx.PamMapDistrictEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


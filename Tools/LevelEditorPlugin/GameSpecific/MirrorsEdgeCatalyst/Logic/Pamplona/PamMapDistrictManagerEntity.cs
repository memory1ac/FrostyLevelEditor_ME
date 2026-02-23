using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapDistrictManagerEntityData))]
	public class PamMapDistrictManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapDistrictManagerEntityData>
	{
		public new FrostySdk.Ebx.PamMapDistrictManagerEntityData Data => data as FrostySdk.Ebx.PamMapDistrictManagerEntityData;
		public override string DisplayName => "PamMapDistrictManager";

		public PamMapDistrictManagerEntity(FrostySdk.Ebx.PamMapDistrictManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


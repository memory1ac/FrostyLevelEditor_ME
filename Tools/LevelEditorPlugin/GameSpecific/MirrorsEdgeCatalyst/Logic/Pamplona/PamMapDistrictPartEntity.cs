using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapDistrictPartEntityData))]
	public class PamMapDistrictPartEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapDistrictPartEntityData>
	{
		public new FrostySdk.Ebx.PamMapDistrictPartEntityData Data => data as FrostySdk.Ebx.PamMapDistrictPartEntityData;
		public override string DisplayName => "PamMapDistrictPart";

		public PamMapDistrictPartEntity(FrostySdk.Ebx.PamMapDistrictPartEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


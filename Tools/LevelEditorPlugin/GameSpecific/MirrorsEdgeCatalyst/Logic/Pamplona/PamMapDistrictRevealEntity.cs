using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapDistrictRevealEntityData))]
	public class PamMapDistrictRevealEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapDistrictRevealEntityData>
	{
		public new FrostySdk.Ebx.PamMapDistrictRevealEntityData Data => data as FrostySdk.Ebx.PamMapDistrictRevealEntityData;
		public override string DisplayName => "PamMapDistrictReveal";

		public PamMapDistrictRevealEntity(FrostySdk.Ebx.PamMapDistrictRevealEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


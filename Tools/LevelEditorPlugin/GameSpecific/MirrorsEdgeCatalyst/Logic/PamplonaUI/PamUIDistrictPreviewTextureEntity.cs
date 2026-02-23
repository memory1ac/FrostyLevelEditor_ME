using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIDistrictPreviewTextureEntityData))]
	public class PamUIDistrictPreviewTextureEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIDistrictPreviewTextureEntityData>
	{
		public new FrostySdk.Ebx.PamUIDistrictPreviewTextureEntityData Data => data as FrostySdk.Ebx.PamUIDistrictPreviewTextureEntityData;
		public override string DisplayName => "PamUIDistrictPreviewTexture";

		public PamUIDistrictPreviewTextureEntity(FrostySdk.Ebx.PamUIDistrictPreviewTextureEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


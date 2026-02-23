using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementGridMaskedTextureEntityData))]
	public class PamUIElementGridMaskedTextureEntity : PamUIElementGriddedRectangleEntity, IEntityData<FrostySdk.Ebx.PamUIElementGridMaskedTextureEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementGridMaskedTextureEntityData Data => data as FrostySdk.Ebx.PamUIElementGridMaskedTextureEntityData;
		public override string DisplayName => "PamUIElementGridMaskedTexture";

		public PamUIElementGridMaskedTextureEntity(FrostySdk.Ebx.PamUIElementGridMaskedTextureEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


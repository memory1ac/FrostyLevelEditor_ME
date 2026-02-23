using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementBitmapEntityData))]
	public class PamUIElementBitmapEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementBitmapEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementBitmapEntityData Data => data as FrostySdk.Ebx.PamUIElementBitmapEntityData;
		public override string DisplayName => "PamUIElementBitmap";

		public PamUIElementBitmapEntity(FrostySdk.Ebx.PamUIElementBitmapEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


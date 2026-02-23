using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AppearancePreviewEntityData))]
	public class AppearancePreviewEntity : AppearanceEntity, IEntityData<FrostySdk.Ebx.AppearancePreviewEntityData>
	{
		public new FrostySdk.Ebx.AppearancePreviewEntityData Data => data as FrostySdk.Ebx.AppearancePreviewEntityData;

		public AppearancePreviewEntity(FrostySdk.Ebx.AppearancePreviewEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


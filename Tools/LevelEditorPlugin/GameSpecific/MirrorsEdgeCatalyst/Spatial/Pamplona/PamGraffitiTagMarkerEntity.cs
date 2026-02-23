using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGraffitiTagMarkerEntityData))]
	public class PamGraffitiTagMarkerEntity : PamSharedContentMarkerEntity, IEntityData<FrostySdk.Ebx.PamGraffitiTagMarkerEntityData>
	{
		public new FrostySdk.Ebx.PamGraffitiTagMarkerEntityData Data => data as FrostySdk.Ebx.PamGraffitiTagMarkerEntityData;

		public PamGraffitiTagMarkerEntity(FrostySdk.Ebx.PamGraffitiTagMarkerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


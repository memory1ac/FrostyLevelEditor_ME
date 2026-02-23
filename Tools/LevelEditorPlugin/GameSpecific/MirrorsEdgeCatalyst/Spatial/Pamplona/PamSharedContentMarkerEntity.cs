using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSharedContentMarkerEntityData))]
	public class PamSharedContentMarkerEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamSharedContentMarkerEntityData>
	{
		public new FrostySdk.Ebx.PamSharedContentMarkerEntityData Data => data as FrostySdk.Ebx.PamSharedContentMarkerEntityData;

		public PamSharedContentMarkerEntity(FrostySdk.Ebx.PamSharedContentMarkerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


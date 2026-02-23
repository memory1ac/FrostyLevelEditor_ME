using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamRunVisTrailRenderEntityData))]
	public class PamRunVisTrailRenderEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamRunVisTrailRenderEntityData>
	{
		public new FrostySdk.Ebx.PamRunVisTrailRenderEntityData Data => data as FrostySdk.Ebx.PamRunVisTrailRenderEntityData;

		public PamRunVisTrailRenderEntity(FrostySdk.Ebx.PamRunVisTrailRenderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


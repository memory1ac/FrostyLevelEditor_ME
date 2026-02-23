using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LensFlareOccluderEntityData))]
	public class LensFlareOccluderEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.LensFlareOccluderEntityData>
	{
		public new FrostySdk.Ebx.LensFlareOccluderEntityData Data => data as FrostySdk.Ebx.LensFlareOccluderEntityData;

		public LensFlareOccluderEntity(FrostySdk.Ebx.LensFlareOccluderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


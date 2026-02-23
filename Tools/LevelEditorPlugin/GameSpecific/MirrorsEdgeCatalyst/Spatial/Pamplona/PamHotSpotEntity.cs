using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamHotSpotEntityData))]
	public class PamHotSpotEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamHotSpotEntityData>
	{
		public new FrostySdk.Ebx.PamHotSpotEntityData Data => data as FrostySdk.Ebx.PamHotSpotEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamHotSpotEntity(FrostySdk.Ebx.PamHotSpotEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


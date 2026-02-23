using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamLineOfSightEntityData))]
	public class PamLineOfSightEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamLineOfSightEntityData>
	{
		public new FrostySdk.Ebx.PamLineOfSightEntityData Data => data as FrostySdk.Ebx.PamLineOfSightEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamLineOfSightEntity(FrostySdk.Ebx.PamLineOfSightEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


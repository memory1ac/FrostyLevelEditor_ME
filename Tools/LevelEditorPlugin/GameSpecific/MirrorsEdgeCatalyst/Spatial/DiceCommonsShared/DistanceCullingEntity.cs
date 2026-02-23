using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DistanceCullingEntityData))]
	public class DistanceCullingEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.DistanceCullingEntityData>
	{
		public new FrostySdk.Ebx.DistanceCullingEntityData Data => data as FrostySdk.Ebx.DistanceCullingEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DistanceCullingEntity(FrostySdk.Ebx.DistanceCullingEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


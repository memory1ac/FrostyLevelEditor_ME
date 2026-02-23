using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AutoPlaythroughMoveToEntityData))]
	public class AutoPlaythroughMoveToEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.AutoPlaythroughMoveToEntityData>
	{
		public new FrostySdk.Ebx.AutoPlaythroughMoveToEntityData Data => data as FrostySdk.Ebx.AutoPlaythroughMoveToEntityData;

		public AutoPlaythroughMoveToEntity(FrostySdk.Ebx.AutoPlaythroughMoveToEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


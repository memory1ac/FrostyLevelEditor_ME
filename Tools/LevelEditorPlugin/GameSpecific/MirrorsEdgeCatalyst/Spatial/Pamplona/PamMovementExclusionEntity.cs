using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMovementExclusionEntityData))]
	public class PamMovementExclusionEntity : PamFindableMovementVolumeEntity, IEntityData<FrostySdk.Ebx.PamMovementExclusionEntityData>
	{
		public new FrostySdk.Ebx.PamMovementExclusionEntityData Data => data as FrostySdk.Ebx.PamMovementExclusionEntityData;

		public PamMovementExclusionEntity(FrostySdk.Ebx.PamMovementExclusionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


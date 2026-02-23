using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUncontrollableSlideEntityData))]
	public class PamUncontrollableSlideEntity : PamFindableMovementVolumeEntity, IEntityData<FrostySdk.Ebx.PamUncontrollableSlideEntityData>
	{
		public new FrostySdk.Ebx.PamUncontrollableSlideEntityData Data => data as FrostySdk.Ebx.PamUncontrollableSlideEntityData;

		public PamUncontrollableSlideEntity(FrostySdk.Ebx.PamUncontrollableSlideEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


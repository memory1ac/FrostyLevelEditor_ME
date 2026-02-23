using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSoftLandingEntityData))]
	public class PamSoftLandingEntity : PamFindableMovementVolumeEntity, IEntityData<FrostySdk.Ebx.PamSoftLandingEntityData>
	{
		public new FrostySdk.Ebx.PamSoftLandingEntityData Data => data as FrostySdk.Ebx.PamSoftLandingEntityData;

		public PamSoftLandingEntity(FrostySdk.Ebx.PamSoftLandingEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


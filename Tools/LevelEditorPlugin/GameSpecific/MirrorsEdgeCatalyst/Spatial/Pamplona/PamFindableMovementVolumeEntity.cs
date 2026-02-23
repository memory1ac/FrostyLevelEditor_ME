using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFindableMovementVolumeEntityData))]
	public class PamFindableMovementVolumeEntity : GameComponentEntity, IEntityData<FrostySdk.Ebx.PamFindableMovementVolumeEntityData>
	{
		public new FrostySdk.Ebx.PamFindableMovementVolumeEntityData Data => data as FrostySdk.Ebx.PamFindableMovementVolumeEntityData;

		public PamFindableMovementVolumeEntity(FrostySdk.Ebx.PamFindableMovementVolumeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


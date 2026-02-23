using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamTargetCameraEntityData))]
	public class PamTargetCameraEntity : TargetCameraEntity, IEntityData<FrostySdk.Ebx.PamTargetCameraEntityData>
	{
		public new FrostySdk.Ebx.PamTargetCameraEntityData Data => data as FrostySdk.Ebx.PamTargetCameraEntityData;

		public PamTargetCameraEntity(FrostySdk.Ebx.PamTargetCameraEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


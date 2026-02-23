using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AutoPlayCameraYawPitchEntityData))]
	public class AutoPlayCameraYawPitchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AutoPlayCameraYawPitchEntityData>
	{
		public new FrostySdk.Ebx.AutoPlayCameraYawPitchEntityData Data => data as FrostySdk.Ebx.AutoPlayCameraYawPitchEntityData;
		public override string DisplayName => "AutoPlayCameraYawPitch";

		public AutoPlayCameraYawPitchEntity(FrostySdk.Ebx.AutoPlayCameraYawPitchEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


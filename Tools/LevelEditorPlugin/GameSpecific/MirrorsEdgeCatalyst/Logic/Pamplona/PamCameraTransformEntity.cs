using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCameraTransformEntityData))]
	public class PamCameraTransformEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamCameraTransformEntityData>
	{
		public new FrostySdk.Ebx.PamCameraTransformEntityData Data => data as FrostySdk.Ebx.PamCameraTransformEntityData;
		public override string DisplayName => "PamCameraTransform";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamCameraTransformEntity(FrostySdk.Ebx.PamCameraTransformEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


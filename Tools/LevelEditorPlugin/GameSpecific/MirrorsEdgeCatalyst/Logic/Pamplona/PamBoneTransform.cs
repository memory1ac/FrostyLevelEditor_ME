using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamBoneTransformData))]
	public class PamBoneTransform : LogicEntity, IEntityData<FrostySdk.Ebx.PamBoneTransformData>
	{
		public new FrostySdk.Ebx.PamBoneTransformData Data => data as FrostySdk.Ebx.PamBoneTransformData;
		public override string DisplayName => "PamBoneTransform";

		public PamBoneTransform(FrostySdk.Ebx.PamBoneTransformData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


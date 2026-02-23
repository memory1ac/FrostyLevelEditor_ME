using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamStartpointTransformEntityData))]
	public class PamStartpointTransformEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamStartpointTransformEntityData>
	{
		public new FrostySdk.Ebx.PamStartpointTransformEntityData Data => data as FrostySdk.Ebx.PamStartpointTransformEntityData;
		public override string DisplayName => "PamStartpointTransform";

		public PamStartpointTransformEntity(FrostySdk.Ebx.PamStartpointTransformEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSharedContentControlEntityData))]
	public class PamSharedContentControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSharedContentControlEntityData>
	{
		public new FrostySdk.Ebx.PamSharedContentControlEntityData Data => data as FrostySdk.Ebx.PamSharedContentControlEntityData;
		public override string DisplayName => "PamSharedContentControl";

		public PamSharedContentControlEntity(FrostySdk.Ebx.PamSharedContentControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSharedContentInfoEntityData))]
	public class PamSharedContentInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSharedContentInfoEntityData>
	{
		public new FrostySdk.Ebx.PamSharedContentInfoEntityData Data => data as FrostySdk.Ebx.PamSharedContentInfoEntityData;
		public override string DisplayName => "PamSharedContentInfo";

		public PamSharedContentInfoEntity(FrostySdk.Ebx.PamSharedContentInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


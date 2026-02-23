using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSharedContentManagerEntityData))]
	public class PamSharedContentManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSharedContentManagerEntityData>
	{
		public new FrostySdk.Ebx.PamSharedContentManagerEntityData Data => data as FrostySdk.Ebx.PamSharedContentManagerEntityData;
		public override string DisplayName => "PamSharedContentManager";

		public PamSharedContentManagerEntity(FrostySdk.Ebx.PamSharedContentManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


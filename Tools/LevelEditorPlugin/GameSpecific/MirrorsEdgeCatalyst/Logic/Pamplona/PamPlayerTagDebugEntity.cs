using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPlayerTagDebugEntityData))]
	public class PamPlayerTagDebugEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamPlayerTagDebugEntityData>
	{
		public new FrostySdk.Ebx.PamPlayerTagDebugEntityData Data => data as FrostySdk.Ebx.PamPlayerTagDebugEntityData;
		public override string DisplayName => "PamPlayerTagDebug";

		public PamPlayerTagDebugEntity(FrostySdk.Ebx.PamPlayerTagDebugEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


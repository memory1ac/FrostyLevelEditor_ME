using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementPlayerTagEntityData))]
	public class PamUIElementPlayerTagEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementPlayerTagEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementPlayerTagEntityData Data => data as FrostySdk.Ebx.PamUIElementPlayerTagEntityData;
		public override string DisplayName => "PamUIElementPlayerTag";

		public PamUIElementPlayerTagEntity(FrostySdk.Ebx.PamUIElementPlayerTagEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementFlowIconsEntityData))]
	public class PamUIElementFlowIconsEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementFlowIconsEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementFlowIconsEntityData Data => data as FrostySdk.Ebx.PamUIElementFlowIconsEntityData;
		public override string DisplayName => "PamUIElementFlowIcons";

		public PamUIElementFlowIconsEntity(FrostySdk.Ebx.PamUIElementFlowIconsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


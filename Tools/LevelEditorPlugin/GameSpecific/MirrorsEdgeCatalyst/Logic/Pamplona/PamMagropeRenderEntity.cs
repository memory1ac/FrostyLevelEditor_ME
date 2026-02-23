using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMagropeRenderEntityData))]
	public class PamMagropeRenderEntity : PamRopeRenderEntity, IEntityData<FrostySdk.Ebx.PamMagropeRenderEntityData>
	{
		public new FrostySdk.Ebx.PamMagropeRenderEntityData Data => data as FrostySdk.Ebx.PamMagropeRenderEntityData;
		public override string DisplayName => "PamMagropeRender";

		public PamMagropeRenderEntity(FrostySdk.Ebx.PamMagropeRenderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


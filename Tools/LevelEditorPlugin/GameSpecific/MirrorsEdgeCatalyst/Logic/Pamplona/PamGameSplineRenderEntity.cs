using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGameSplineRenderEntityData))]
	public class PamGameSplineRenderEntity : PamRopeRenderEntity, IEntityData<FrostySdk.Ebx.PamGameSplineRenderEntityData>
	{
		public new FrostySdk.Ebx.PamGameSplineRenderEntityData Data => data as FrostySdk.Ebx.PamGameSplineRenderEntityData;
		public override string DisplayName => "PamGameSplineRender";

		public PamGameSplineRenderEntity(FrostySdk.Ebx.PamGameSplineRenderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


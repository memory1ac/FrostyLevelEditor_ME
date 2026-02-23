using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamRopeRenderEntityData))]
	public class PamRopeRenderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamRopeRenderEntityData>
	{
		public new FrostySdk.Ebx.PamRopeRenderEntityData Data => data as FrostySdk.Ebx.PamRopeRenderEntityData;
		public override string DisplayName => "PamRopeRender";

		public PamRopeRenderEntity(FrostySdk.Ebx.PamRopeRenderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


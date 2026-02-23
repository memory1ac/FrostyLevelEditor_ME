using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFlowEntityData))]
	public class PamFlowEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamFlowEntityData>
	{
		public new FrostySdk.Ebx.PamFlowEntityData Data => data as FrostySdk.Ebx.PamFlowEntityData;
		public override string DisplayName => "PamFlow";

		public PamFlowEntity(FrostySdk.Ebx.PamFlowEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


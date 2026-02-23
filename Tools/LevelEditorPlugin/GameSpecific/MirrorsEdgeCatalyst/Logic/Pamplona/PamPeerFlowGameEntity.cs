using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPeerFlowGameEntityData))]
	public class PamPeerFlowGameEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamPeerFlowGameEntityData>
	{
		public new FrostySdk.Ebx.PamPeerFlowGameEntityData Data => data as FrostySdk.Ebx.PamPeerFlowGameEntityData;
		public override string DisplayName => "PamPeerFlowGame";

		public PamPeerFlowGameEntity(FrostySdk.Ebx.PamPeerFlowGameEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateBrainDeadData))]
	public class PamAIStateBrainDead : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateBrainDeadData>
	{
		public new FrostySdk.Ebx.PamAIStateBrainDeadData Data => data as FrostySdk.Ebx.PamAIStateBrainDeadData;
		public override string DisplayName => "PamAIStateBrainDead";

		public PamAIStateBrainDead(FrostySdk.Ebx.PamAIStateBrainDeadData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


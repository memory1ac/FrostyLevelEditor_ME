using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateMeleeDefenseData))]
	public class PamAIStateMeleeDefense : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateMeleeDefenseData>
	{
		public new FrostySdk.Ebx.PamAIStateMeleeDefenseData Data => data as FrostySdk.Ebx.PamAIStateMeleeDefenseData;
		public override string DisplayName => "PamAIStateMeleeDefense";

		public PamAIStateMeleeDefense(FrostySdk.Ebx.PamAIStateMeleeDefenseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


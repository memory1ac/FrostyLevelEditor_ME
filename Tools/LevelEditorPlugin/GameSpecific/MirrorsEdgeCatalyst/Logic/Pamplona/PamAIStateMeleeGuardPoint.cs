using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateMeleeGuardPointData))]
	public class PamAIStateMeleeGuardPoint : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateMeleeGuardPointData>
	{
		public new FrostySdk.Ebx.PamAIStateMeleeGuardPointData Data => data as FrostySdk.Ebx.PamAIStateMeleeGuardPointData;
		public override string DisplayName => "PamAIStateMeleeGuardPoint";

		public PamAIStateMeleeGuardPoint(FrostySdk.Ebx.PamAIStateMeleeGuardPointData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


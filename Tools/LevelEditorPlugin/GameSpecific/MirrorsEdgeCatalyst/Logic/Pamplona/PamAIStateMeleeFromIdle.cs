using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateMeleeFromIdleData))]
	public class PamAIStateMeleeFromIdle : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateMeleeFromIdleData>
	{
		public new FrostySdk.Ebx.PamAIStateMeleeFromIdleData Data => data as FrostySdk.Ebx.PamAIStateMeleeFromIdleData;
		public override string DisplayName => "PamAIStateMeleeFromIdle";

		public PamAIStateMeleeFromIdle(FrostySdk.Ebx.PamAIStateMeleeFromIdleData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


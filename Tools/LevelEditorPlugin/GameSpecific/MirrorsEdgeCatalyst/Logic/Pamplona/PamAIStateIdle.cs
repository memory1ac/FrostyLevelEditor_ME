using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateIdleData))]
	public class PamAIStateIdle : AIStateIdle, IEntityData<FrostySdk.Ebx.PamAIStateIdleData>
	{
		public new FrostySdk.Ebx.PamAIStateIdleData Data => data as FrostySdk.Ebx.PamAIStateIdleData;
		public override string DisplayName => "PamAIStateIdle";

		public PamAIStateIdle(FrostySdk.Ebx.PamAIStateIdleData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


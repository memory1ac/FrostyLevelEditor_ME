using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIStateIdleData))]
	public class AIStateIdle : AIState, IEntityData<FrostySdk.Ebx.AIStateIdleData>
	{
		public new FrostySdk.Ebx.AIStateIdleData Data => data as FrostySdk.Ebx.AIStateIdleData;
		public override string DisplayName => "AIStateIdle";

		public AIStateIdle(FrostySdk.Ebx.AIStateIdleData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


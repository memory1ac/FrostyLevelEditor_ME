using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIStateFireFromPositionData))]
	public class AIStateFireFromPosition : AIState, IEntityData<FrostySdk.Ebx.AIStateFireFromPositionData>
	{
		public new FrostySdk.Ebx.AIStateFireFromPositionData Data => data as FrostySdk.Ebx.AIStateFireFromPositionData;
		public override string DisplayName => "AIStateFireFromPosition";

		public AIStateFireFromPosition(FrostySdk.Ebx.AIStateFireFromPositionData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


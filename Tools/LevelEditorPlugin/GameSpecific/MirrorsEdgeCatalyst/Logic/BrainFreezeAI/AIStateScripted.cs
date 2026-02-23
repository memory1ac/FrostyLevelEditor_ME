using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIStateScriptedData))]
	public class AIStateScripted : AIState, IEntityData<FrostySdk.Ebx.AIStateScriptedData>
	{
		public new FrostySdk.Ebx.AIStateScriptedData Data => data as FrostySdk.Ebx.AIStateScriptedData;
		public override string DisplayName => "AIStateScripted";

		public AIStateScripted(FrostySdk.Ebx.AIStateScriptedData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


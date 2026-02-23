using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIBehaviourNodeBaseData))]
	public class AIBehaviourNodeBase : LogicEntity, IEntityData<FrostySdk.Ebx.AIBehaviourNodeBaseData>
	{
		public new FrostySdk.Ebx.AIBehaviourNodeBaseData Data => data as FrostySdk.Ebx.AIBehaviourNodeBaseData;
		public override string DisplayName => "AIBehaviourNodeBase";

		public AIBehaviourNodeBase(FrostySdk.Ebx.AIBehaviourNodeBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


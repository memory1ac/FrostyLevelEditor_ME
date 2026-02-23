using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AITypeEventGateEntityData))]
	public class AITypeEventGateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AITypeEventGateEntityData>
	{
		public new FrostySdk.Ebx.AITypeEventGateEntityData Data => data as FrostySdk.Ebx.AITypeEventGateEntityData;
		public override string DisplayName => "AITypeEventGate";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AITypeEventGateEntity(FrostySdk.Ebx.AITypeEventGateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


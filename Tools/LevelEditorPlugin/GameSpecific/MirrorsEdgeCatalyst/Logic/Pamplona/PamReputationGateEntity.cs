using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamReputationGateEntityData))]
	public class PamReputationGateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamReputationGateEntityData>
	{
		public new FrostySdk.Ebx.PamReputationGateEntityData Data => data as FrostySdk.Ebx.PamReputationGateEntityData;
		public override string DisplayName => "PamReputationGate";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamReputationGateEntity(FrostySdk.Ebx.PamReputationGateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


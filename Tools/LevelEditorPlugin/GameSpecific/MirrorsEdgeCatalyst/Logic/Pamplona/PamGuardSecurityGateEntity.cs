using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGuardSecurityGateEntityData))]
	public class PamGuardSecurityGateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamGuardSecurityGateEntityData>
	{
		public new FrostySdk.Ebx.PamGuardSecurityGateEntityData Data => data as FrostySdk.Ebx.PamGuardSecurityGateEntityData;
		public override string DisplayName => "PamGuardSecurityGate";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamGuardSecurityGateEntity(FrostySdk.Ebx.PamGuardSecurityGateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


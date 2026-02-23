using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIActiveMissionInfoEntityData))]
	public class PamUIActiveMissionInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIActiveMissionInfoEntityData>
	{
		public new FrostySdk.Ebx.PamUIActiveMissionInfoEntityData Data => data as FrostySdk.Ebx.PamUIActiveMissionInfoEntityData;
		public override string DisplayName => "PamUIActiveMissionInfo";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIActiveMissionInfoEntity(FrostySdk.Ebx.PamUIActiveMissionInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


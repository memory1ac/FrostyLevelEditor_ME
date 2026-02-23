using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIAvailableMissionInfoEntityData))]
	public class PamUIAvailableMissionInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIAvailableMissionInfoEntityData>
	{
		public new FrostySdk.Ebx.PamUIAvailableMissionInfoEntityData Data => data as FrostySdk.Ebx.PamUIAvailableMissionInfoEntityData;
		public override string DisplayName => "PamUIAvailableMissionInfo";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIAvailableMissionInfoEntity(FrostySdk.Ebx.PamUIAvailableMissionInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


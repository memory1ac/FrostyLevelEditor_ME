using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUINotificationSenderEntityData))]
	public class PamUINotificationSenderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUINotificationSenderEntityData>
	{
		public new FrostySdk.Ebx.PamUINotificationSenderEntityData Data => data as FrostySdk.Ebx.PamUINotificationSenderEntityData;
		public override string DisplayName => "PamUINotificationSender";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUINotificationSenderEntity(FrostySdk.Ebx.PamUINotificationSenderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


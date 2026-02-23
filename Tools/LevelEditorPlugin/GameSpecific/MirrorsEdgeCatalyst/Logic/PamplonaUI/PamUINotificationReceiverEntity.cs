using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUINotificationReceiverEntityData))]
	public class PamUINotificationReceiverEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUINotificationReceiverEntityData>
	{
		public new FrostySdk.Ebx.PamUINotificationReceiverEntityData Data => data as FrostySdk.Ebx.PamUINotificationReceiverEntityData;
		public override string DisplayName => "PamUINotificationReceiver";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUINotificationReceiverEntity(FrostySdk.Ebx.PamUINotificationReceiverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


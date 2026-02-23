using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamDivisionNotificationEntityData))]
	public class PamDivisionNotificationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamDivisionNotificationEntityData>
	{
		public new FrostySdk.Ebx.PamDivisionNotificationEntityData Data => data as FrostySdk.Ebx.PamDivisionNotificationEntityData;
		public override string DisplayName => "PamDivisionNotification";

		public PamDivisionNotificationEntity(FrostySdk.Ebx.PamDivisionNotificationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


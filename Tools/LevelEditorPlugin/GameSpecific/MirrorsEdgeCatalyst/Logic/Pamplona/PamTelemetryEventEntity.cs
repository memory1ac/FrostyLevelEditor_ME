using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamTelemetryEventEntityData))]
	public class PamTelemetryEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamTelemetryEventEntityData>
	{
		public new FrostySdk.Ebx.PamTelemetryEventEntityData Data => data as FrostySdk.Ebx.PamTelemetryEventEntityData;
		public override string DisplayName => "PamTelemetryEvent";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamTelemetryEventEntity(FrostySdk.Ebx.PamTelemetryEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


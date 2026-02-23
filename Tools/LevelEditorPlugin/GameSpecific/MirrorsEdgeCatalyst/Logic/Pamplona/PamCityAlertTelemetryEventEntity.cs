using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCityAlertTelemetryEventEntityData))]
	public class PamCityAlertTelemetryEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamCityAlertTelemetryEventEntityData>
	{
		public new FrostySdk.Ebx.PamCityAlertTelemetryEventEntityData Data => data as FrostySdk.Ebx.PamCityAlertTelemetryEventEntityData;
		public override string DisplayName => "PamCityAlertTelemetryEvent";

		public PamCityAlertTelemetryEventEntity(FrostySdk.Ebx.PamCityAlertTelemetryEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TelemetryPinEventEntityData))]
public class TelemetryPinEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TelemetryPinEventEntityData>
{
    public new FrostySdk.Ebx.TelemetryPinEventEntityData Data => data as FrostySdk.Ebx.TelemetryPinEventEntityData;
    public override string DisplayName => "TelemetryPinEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TelemetryPinEventEntity(FrostySdk.Ebx.TelemetryPinEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


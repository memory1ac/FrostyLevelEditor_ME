namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFTelemetryPinEventEntityData))]
public class BFTelemetryPinEventEntity : TelemetryPinEventEntity, IEntityData<FrostySdk.Ebx.BFTelemetryPinEventEntityData>
{
    public new FrostySdk.Ebx.BFTelemetryPinEventEntityData Data => data as FrostySdk.Ebx.BFTelemetryPinEventEntityData;
    public override string DisplayName => "BFTelemetryPinEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFTelemetryPinEventEntity(FrostySdk.Ebx.BFTelemetryPinEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


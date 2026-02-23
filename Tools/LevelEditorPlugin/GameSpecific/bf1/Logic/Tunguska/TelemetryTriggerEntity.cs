namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TelemetryTriggerEntityData))]
public class TelemetryTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TelemetryTriggerEntityData>
{
    public new FrostySdk.Ebx.TelemetryTriggerEntityData Data => data as FrostySdk.Ebx.TelemetryTriggerEntityData;
    public override string DisplayName => "TelemetryTrigger";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TelemetryTriggerEntity(FrostySdk.Ebx.TelemetryTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


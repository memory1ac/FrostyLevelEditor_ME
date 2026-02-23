namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LogitechLedEntityData))]
public class LogitechLedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LogitechLedEntityData>
{
    public new FrostySdk.Ebx.LogitechLedEntityData Data => data as FrostySdk.Ebx.LogitechLedEntityData;
    public override string DisplayName => "LogitechLed";

    public LogitechLedEntity(FrostySdk.Ebx.LogitechLedEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


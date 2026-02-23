namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LogitechArxEntityData))]
public class LogitechArxEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LogitechArxEntityData>
{
    public new FrostySdk.Ebx.LogitechArxEntityData Data => data as FrostySdk.Ebx.LogitechArxEntityData;
    public override string DisplayName => "LogitechArx";

    public LogitechArxEntity(FrostySdk.Ebx.LogitechArxEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


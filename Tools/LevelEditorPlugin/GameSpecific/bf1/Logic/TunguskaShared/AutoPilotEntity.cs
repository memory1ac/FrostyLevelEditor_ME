namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AutoPilotEntityData))]
public class AutoPilotEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AutoPilotEntityData>
{
    public new FrostySdk.Ebx.AutoPilotEntityData Data => data as FrostySdk.Ebx.AutoPilotEntityData;
    public override string DisplayName => "AutoPilot";

    public AutoPilotEntity(FrostySdk.Ebx.AutoPilotEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


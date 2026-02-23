namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MotorbikeVisualSuspensionEntityData))]
public class MotorbikeVisualSuspensionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MotorbikeVisualSuspensionEntityData>
{
    public new FrostySdk.Ebx.MotorbikeVisualSuspensionEntityData Data => data as FrostySdk.Ebx.MotorbikeVisualSuspensionEntityData;
    public override string DisplayName => "MotorbikeVisualSuspension";

    public MotorbikeVisualSuspensionEntity(FrostySdk.Ebx.MotorbikeVisualSuspensionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AimingWorldLockEfficiencyEntityData))]
public class AimingWorldLockEfficiencyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AimingWorldLockEfficiencyEntityData>
{
    public new FrostySdk.Ebx.AimingWorldLockEfficiencyEntityData Data => data as FrostySdk.Ebx.AimingWorldLockEfficiencyEntityData;
    public override string DisplayName => "AimingWorldLockEfficiency";

    public AimingWorldLockEfficiencyEntity(FrostySdk.Ebx.AimingWorldLockEfficiencyEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


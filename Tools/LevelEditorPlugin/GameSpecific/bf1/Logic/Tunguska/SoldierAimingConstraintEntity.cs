namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierAimingConstraintEntityData))]
public class SoldierAimingConstraintEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SoldierAimingConstraintEntityData>
{
    public new FrostySdk.Ebx.SoldierAimingConstraintEntityData Data => data as FrostySdk.Ebx.SoldierAimingConstraintEntityData;
    public override string DisplayName => "SoldierAimingConstraint";

    public SoldierAimingConstraintEntity(FrostySdk.Ebx.SoldierAimingConstraintEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


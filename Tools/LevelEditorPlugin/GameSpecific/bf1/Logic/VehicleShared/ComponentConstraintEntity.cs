namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ComponentConstraintEntityData))]
public class ComponentConstraintEntity : ComponentTransformEntityBase, IEntityData<FrostySdk.Ebx.ComponentConstraintEntityData>
{
    public new FrostySdk.Ebx.ComponentConstraintEntityData Data => data as FrostySdk.Ebx.ComponentConstraintEntityData;
    public override string DisplayName => "ComponentConstraint";

    public ComponentConstraintEntity(FrostySdk.Ebx.ComponentConstraintEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


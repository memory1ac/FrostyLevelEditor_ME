namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PropertyOptimizationCheckEntityData))]
public class PropertyOptimizationCheckEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PropertyOptimizationCheckEntityData>
{
    public new FrostySdk.Ebx.PropertyOptimizationCheckEntityData Data => data as FrostySdk.Ebx.PropertyOptimizationCheckEntityData;
    public override string DisplayName => "PropertyOptimizationCheck";

    public PropertyOptimizationCheckEntity(FrostySdk.Ebx.PropertyOptimizationCheckEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


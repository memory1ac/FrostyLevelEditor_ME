namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpottingDistanceScaleEntityData))]
public class SpottingDistanceScaleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpottingDistanceScaleEntityData>
{
    public new FrostySdk.Ebx.SpottingDistanceScaleEntityData Data => data as FrostySdk.Ebx.SpottingDistanceScaleEntityData;
    public override string DisplayName => "SpottingDistanceScale";

    public SpottingDistanceScaleEntity(FrostySdk.Ebx.SpottingDistanceScaleEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


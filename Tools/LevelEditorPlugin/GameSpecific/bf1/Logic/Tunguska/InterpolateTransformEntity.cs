namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.InterpolateTransformEntityData))]
public class InterpolateTransformEntity : LogicEntity, IEntityData<FrostySdk.Ebx.InterpolateTransformEntityData>
{
    public new FrostySdk.Ebx.InterpolateTransformEntityData Data => data as FrostySdk.Ebx.InterpolateTransformEntityData;
    public override string DisplayName => "InterpolateTransform";

    public InterpolateTransformEntity(FrostySdk.Ebx.InterpolateTransformEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


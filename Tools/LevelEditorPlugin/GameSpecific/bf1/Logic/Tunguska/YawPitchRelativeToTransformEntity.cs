namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.YawPitchRelativeToTransformEntityData))]
public class YawPitchRelativeToTransformEntity : LogicEntity, IEntityData<FrostySdk.Ebx.YawPitchRelativeToTransformEntityData>
{
    public new FrostySdk.Ebx.YawPitchRelativeToTransformEntityData Data => data as FrostySdk.Ebx.YawPitchRelativeToTransformEntityData;
    public override string DisplayName => "YawPitchRelativeToTransform";

    public YawPitchRelativeToTransformEntity(FrostySdk.Ebx.YawPitchRelativeToTransformEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


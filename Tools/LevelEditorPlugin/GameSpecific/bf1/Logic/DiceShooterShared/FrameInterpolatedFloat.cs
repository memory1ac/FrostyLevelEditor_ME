namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrameInterpolatedFloatData))]
public class FrameInterpolatedFloat : LogicEntity, IEntityData<FrostySdk.Ebx.FrameInterpolatedFloatData>
{
    public new FrostySdk.Ebx.FrameInterpolatedFloatData Data => data as FrostySdk.Ebx.FrameInterpolatedFloatData;
    public override string DisplayName => "FrameInterpolatedFloat";

    public FrameInterpolatedFloat(FrostySdk.Ebx.FrameInterpolatedFloatData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetFrontlineCapturePointsEntityData))]
public class BFUIGetFrontlineCapturePointsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetFrontlineCapturePointsEntityData>
{
    public new FrostySdk.Ebx.BFUIGetFrontlineCapturePointsEntityData Data => data as FrostySdk.Ebx.BFUIGetFrontlineCapturePointsEntityData;
    public override string DisplayName => "BFUIGetFrontlineCapturePoints";

    public BFUIGetFrontlineCapturePointsEntity(FrostySdk.Ebx.BFUIGetFrontlineCapturePointsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


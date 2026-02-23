namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetCapturePointEntityData))]
public class BFUIGetCapturePointEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetCapturePointEntityData>
{
    public new FrostySdk.Ebx.BFUIGetCapturePointEntityData Data => data as FrostySdk.Ebx.BFUIGetCapturePointEntityData;
    public override string DisplayName => "BFUIGetCapturePoint";

    public BFUIGetCapturePointEntity(FrostySdk.Ebx.BFUIGetCapturePointEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


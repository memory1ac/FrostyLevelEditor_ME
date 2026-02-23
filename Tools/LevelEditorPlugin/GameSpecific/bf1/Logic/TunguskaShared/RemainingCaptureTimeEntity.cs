namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.RemainingCaptureTimeEntityData))]
public class RemainingCaptureTimeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.RemainingCaptureTimeEntityData>
{
    public new FrostySdk.Ebx.RemainingCaptureTimeEntityData Data => data as FrostySdk.Ebx.RemainingCaptureTimeEntityData;
    public override string DisplayName => "RemainingCaptureTime";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public RemainingCaptureTimeEntity(FrostySdk.Ebx.RemainingCaptureTimeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


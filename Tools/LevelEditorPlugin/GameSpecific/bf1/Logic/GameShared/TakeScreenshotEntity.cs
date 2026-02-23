namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TakeScreenshotEntityData))]
public class TakeScreenshotEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TakeScreenshotEntityData>
{
    public new FrostySdk.Ebx.TakeScreenshotEntityData Data => data as FrostySdk.Ebx.TakeScreenshotEntityData;
    public override string DisplayName => "TakeScreenshot";

    public TakeScreenshotEntity(FrostySdk.Ebx.TakeScreenshotEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


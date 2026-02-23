namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WebBrowserOverlayEntityData))]
public class WebBrowserOverlayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WebBrowserOverlayEntityData>
{
    public new FrostySdk.Ebx.WebBrowserOverlayEntityData Data => data as FrostySdk.Ebx.WebBrowserOverlayEntityData;
    public override string DisplayName => "WebBrowserOverlay";

    public WebBrowserOverlayEntity(FrostySdk.Ebx.WebBrowserOverlayEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


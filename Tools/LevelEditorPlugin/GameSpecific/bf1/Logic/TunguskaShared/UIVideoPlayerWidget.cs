namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIVideoPlayerWidgetData))]
public class UIVideoPlayerWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIVideoPlayerWidgetData>
{
    public new FrostySdk.Ebx.UIVideoPlayerWidgetData Data => data as FrostySdk.Ebx.UIVideoPlayerWidgetData;
    public override string DisplayName => "UIVideoPlayerWidget";

    public UIVideoPlayerWidget(FrostySdk.Ebx.UIVideoPlayerWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


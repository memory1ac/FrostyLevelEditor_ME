namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISubtitlesWidgetData))]
public class UISubtitlesWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UISubtitlesWidgetData>
{
    public new FrostySdk.Ebx.UISubtitlesWidgetData Data => data as FrostySdk.Ebx.UISubtitlesWidgetData;
    public override string DisplayName => "UISubtitlesWidget";

    public UISubtitlesWidget(FrostySdk.Ebx.UISubtitlesWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


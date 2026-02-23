namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIShowVoipSpeakersWidgetData))]
public class UIShowVoipSpeakersWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIShowVoipSpeakersWidgetData>
{
    public new FrostySdk.Ebx.UIShowVoipSpeakersWidgetData Data => data as FrostySdk.Ebx.UIShowVoipSpeakersWidgetData;
    public override string DisplayName => "UIShowVoipSpeakersWidget";

    public UIShowVoipSpeakersWidget(FrostySdk.Ebx.UIShowVoipSpeakersWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


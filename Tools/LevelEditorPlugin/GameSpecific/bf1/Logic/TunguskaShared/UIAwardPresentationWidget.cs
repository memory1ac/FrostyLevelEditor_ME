namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIAwardPresentationWidgetData))]
public class UIAwardPresentationWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIAwardPresentationWidgetData>
{
    public new FrostySdk.Ebx.UIAwardPresentationWidgetData Data => data as FrostySdk.Ebx.UIAwardPresentationWidgetData;
    public override string DisplayName => "UIAwardPresentationWidget";

    public UIAwardPresentationWidget(FrostySdk.Ebx.UIAwardPresentationWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


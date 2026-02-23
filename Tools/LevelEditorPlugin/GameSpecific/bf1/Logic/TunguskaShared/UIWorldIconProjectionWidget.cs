namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIWorldIconProjectionWidgetData))]
public class UIWorldIconProjectionWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIWorldIconProjectionWidgetData>
{
    public new FrostySdk.Ebx.UIWorldIconProjectionWidgetData Data => data as FrostySdk.Ebx.UIWorldIconProjectionWidgetData;
    public override string DisplayName => "UIWorldIconProjectionWidget";

    public UIWorldIconProjectionWidget(FrostySdk.Ebx.UIWorldIconProjectionWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


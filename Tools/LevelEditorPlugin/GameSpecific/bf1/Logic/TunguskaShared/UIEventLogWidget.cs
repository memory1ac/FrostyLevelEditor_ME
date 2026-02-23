namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIEventLogWidgetData))]
public class UIEventLogWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIEventLogWidgetData>
{
    public new FrostySdk.Ebx.UIEventLogWidgetData Data => data as FrostySdk.Ebx.UIEventLogWidgetData;
    public override string DisplayName => "UIEventLogWidget";

    public UIEventLogWidget(FrostySdk.Ebx.UIEventLogWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICurrentCommanderWidgetData))]
public class UICurrentCommanderWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICurrentCommanderWidgetData>
{
    public new FrostySdk.Ebx.UICurrentCommanderWidgetData Data => data as FrostySdk.Ebx.UICurrentCommanderWidgetData;
    public override string DisplayName => "UICurrentCommanderWidget";

    public UICurrentCommanderWidget(FrostySdk.Ebx.UICurrentCommanderWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


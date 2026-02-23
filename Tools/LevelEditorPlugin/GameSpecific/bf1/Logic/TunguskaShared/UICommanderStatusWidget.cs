namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommanderStatusWidgetData))]
public class UICommanderStatusWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICommanderStatusWidgetData>
{
    public new FrostySdk.Ebx.UICommanderStatusWidgetData Data => data as FrostySdk.Ebx.UICommanderStatusWidgetData;
    public override string DisplayName => "UICommanderStatusWidget";

    public UICommanderStatusWidget(FrostySdk.Ebx.UICommanderStatusWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


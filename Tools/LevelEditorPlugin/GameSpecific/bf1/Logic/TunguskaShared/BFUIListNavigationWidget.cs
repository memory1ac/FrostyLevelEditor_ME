namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIListNavigationWidgetData))]
public class BFUIListNavigationWidget : BFUINavigationWidget, IEntityData<FrostySdk.Ebx.BFUIListNavigationWidgetData>
{
    public new FrostySdk.Ebx.BFUIListNavigationWidgetData Data => data as FrostySdk.Ebx.BFUIListNavigationWidgetData;
    public override string DisplayName => "BFUIListNavigationWidget";

    public BFUIListNavigationWidget(FrostySdk.Ebx.BFUIListNavigationWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


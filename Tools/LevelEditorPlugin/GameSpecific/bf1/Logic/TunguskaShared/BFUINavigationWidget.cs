namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUINavigationWidgetData))]
public class BFUINavigationWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUINavigationWidgetData>
{
    public new FrostySdk.Ebx.BFUINavigationWidgetData Data => data as FrostySdk.Ebx.BFUINavigationWidgetData;
    public override string DisplayName => "BFUINavigationWidget";

    public BFUINavigationWidget(FrostySdk.Ebx.BFUINavigationWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


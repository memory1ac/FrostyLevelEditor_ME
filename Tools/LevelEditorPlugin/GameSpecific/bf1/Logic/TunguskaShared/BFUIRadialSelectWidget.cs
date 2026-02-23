namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIRadialSelectWidgetData))]
public class BFUIRadialSelectWidget : BFUINavigationWidget, IEntityData<FrostySdk.Ebx.BFUIRadialSelectWidgetData>
{
    public new FrostySdk.Ebx.BFUIRadialSelectWidgetData Data => data as FrostySdk.Ebx.BFUIRadialSelectWidgetData;
    public override string DisplayName => "BFUIRadialSelectWidget";

    public BFUIRadialSelectWidget(FrostySdk.Ebx.BFUIRadialSelectWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


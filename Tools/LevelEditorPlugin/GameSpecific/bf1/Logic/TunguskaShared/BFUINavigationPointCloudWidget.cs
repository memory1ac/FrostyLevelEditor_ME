namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUINavigationPointCloudWidgetData))]
public class BFUINavigationPointCloudWidget : BFUINavigationWidget, IEntityData<FrostySdk.Ebx.BFUINavigationPointCloudWidgetData>
{
    public new FrostySdk.Ebx.BFUINavigationPointCloudWidgetData Data => data as FrostySdk.Ebx.BFUINavigationPointCloudWidgetData;
    public override string DisplayName => "BFUINavigationPointCloudWidget";

    public BFUINavigationPointCloudWidget(FrostySdk.Ebx.BFUINavigationPointCloudWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


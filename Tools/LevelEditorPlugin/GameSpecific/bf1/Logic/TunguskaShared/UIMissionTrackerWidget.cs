namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMissionTrackerWidgetData))]
public class UIMissionTrackerWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMissionTrackerWidgetData>
{
    public new FrostySdk.Ebx.UIMissionTrackerWidgetData Data => data as FrostySdk.Ebx.UIMissionTrackerWidgetData;
    public override string DisplayName => "UIMissionTrackerWidget";

    public UIMissionTrackerWidget(FrostySdk.Ebx.UIMissionTrackerWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


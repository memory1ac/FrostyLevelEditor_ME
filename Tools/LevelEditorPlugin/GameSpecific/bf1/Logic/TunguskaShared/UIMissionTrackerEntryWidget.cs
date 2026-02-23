namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMissionTrackerEntryWidgetData))]
public class UIMissionTrackerEntryWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMissionTrackerEntryWidgetData>
{
    public new FrostySdk.Ebx.UIMissionTrackerEntryWidgetData Data => data as FrostySdk.Ebx.UIMissionTrackerEntryWidgetData;
    public override string DisplayName => "UIMissionTrackerEntryWidget";

    public UIMissionTrackerEntryWidget(FrostySdk.Ebx.UIMissionTrackerEntryWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


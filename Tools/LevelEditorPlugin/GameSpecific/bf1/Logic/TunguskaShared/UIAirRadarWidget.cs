namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIAirRadarWidgetData))]
public class UIAirRadarWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIAirRadarWidgetData>
{
    public new FrostySdk.Ebx.UIAirRadarWidgetData Data => data as FrostySdk.Ebx.UIAirRadarWidgetData;
    public override string DisplayName => "UIAirRadarWidget";

    public UIAirRadarWidget(FrostySdk.Ebx.UIAirRadarWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


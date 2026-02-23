namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommanderVehicleWidgetData))]
public class UICommanderVehicleWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICommanderVehicleWidgetData>
{
    public new FrostySdk.Ebx.UICommanderVehicleWidgetData Data => data as FrostySdk.Ebx.UICommanderVehicleWidgetData;
    public override string DisplayName => "UICommanderVehicleWidget";

    public UICommanderVehicleWidget(FrostySdk.Ebx.UICommanderVehicleWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


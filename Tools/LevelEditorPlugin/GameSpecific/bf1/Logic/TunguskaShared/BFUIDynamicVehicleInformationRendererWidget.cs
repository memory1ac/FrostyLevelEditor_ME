namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIDynamicVehicleInformationRendererWidgetData))]
public class BFUIDynamicVehicleInformationRendererWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUIDynamicVehicleInformationRendererWidgetData>
{
    public new FrostySdk.Ebx.BFUIDynamicVehicleInformationRendererWidgetData Data => data as FrostySdk.Ebx.BFUIDynamicVehicleInformationRendererWidgetData;
    public override string DisplayName => "BFUIDynamicVehicleInformationRendererWidget";

    public BFUIDynamicVehicleInformationRendererWidget(FrostySdk.Ebx.BFUIDynamicVehicleInformationRendererWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


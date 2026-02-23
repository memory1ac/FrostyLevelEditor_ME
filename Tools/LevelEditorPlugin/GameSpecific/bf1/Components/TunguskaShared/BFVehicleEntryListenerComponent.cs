
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFVehicleEntryListenerComponentData))]
public class BFVehicleEntryListenerComponent : VehicleEntryListenerComponent, IEntityData<FrostySdk.Ebx.BFVehicleEntryListenerComponentData>
{
    public new FrostySdk.Ebx.BFVehicleEntryListenerComponentData Data => data as FrostySdk.Ebx.BFVehicleEntryListenerComponentData;
    public override string DisplayName => "BFVehicleEntryListenerComponent";

    public BFVehicleEntryListenerComponent(FrostySdk.Ebx.BFVehicleEntryListenerComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


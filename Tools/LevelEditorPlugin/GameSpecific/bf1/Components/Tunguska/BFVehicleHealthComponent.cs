
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFVehicleHealthComponentData))]
public class BFVehicleHealthComponent : VehicleHealthComponent, IEntityData<FrostySdk.Ebx.BFVehicleHealthComponentData>
{
    public new FrostySdk.Ebx.BFVehicleHealthComponentData Data => data as FrostySdk.Ebx.BFVehicleHealthComponentData;
    public override string DisplayName => "BFVehicleHealthComponent";

    public BFVehicleHealthComponent(FrostySdk.Ebx.BFVehicleHealthComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


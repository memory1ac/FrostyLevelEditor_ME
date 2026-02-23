
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFVehiclePhysicsComponentData))]
public class BFVehiclePhysicsComponent : VehiclePhysicsComponent, IEntityData<FrostySdk.Ebx.BFVehiclePhysicsComponentData>
{
    public new FrostySdk.Ebx.BFVehiclePhysicsComponentData Data => data as FrostySdk.Ebx.BFVehiclePhysicsComponentData;
    public override string DisplayName => "BFVehiclePhysicsComponent";

    public BFVehiclePhysicsComponent(FrostySdk.Ebx.BFVehiclePhysicsComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


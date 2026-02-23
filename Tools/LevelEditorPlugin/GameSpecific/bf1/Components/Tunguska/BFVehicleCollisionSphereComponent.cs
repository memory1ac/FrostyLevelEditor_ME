
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFVehicleCollisionSphereComponentData))]
public class BFVehicleCollisionSphereComponent : GameComponent, IEntityData<FrostySdk.Ebx.BFVehicleCollisionSphereComponentData>
{
    public new FrostySdk.Ebx.BFVehicleCollisionSphereComponentData Data => data as FrostySdk.Ebx.BFVehicleCollisionSphereComponentData;
    public override string DisplayName => "BFVehicleCollisionSphereComponent";

    public BFVehicleCollisionSphereComponent(FrostySdk.Ebx.BFVehicleCollisionSphereComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


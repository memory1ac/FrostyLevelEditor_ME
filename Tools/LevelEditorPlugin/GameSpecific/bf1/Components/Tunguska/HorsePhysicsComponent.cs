
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.HorsePhysicsComponentData))]
public class HorsePhysicsComponent : VehiclePhysicsComponent, IEntityData<FrostySdk.Ebx.HorsePhysicsComponentData>
{
    public new FrostySdk.Ebx.HorsePhysicsComponentData Data => data as FrostySdk.Ebx.HorsePhysicsComponentData;
    public override string DisplayName => "HorsePhysicsComponent";

    public HorsePhysicsComponent(FrostySdk.Ebx.HorsePhysicsComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


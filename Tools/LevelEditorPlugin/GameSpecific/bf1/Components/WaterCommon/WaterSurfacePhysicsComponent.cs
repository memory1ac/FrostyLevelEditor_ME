
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WaterSurfacePhysicsComponentData))]
public class WaterSurfacePhysicsComponent : GamePhysicsComponent, IEntityData<FrostySdk.Ebx.WaterSurfacePhysicsComponentData>
{
    public new FrostySdk.Ebx.WaterSurfacePhysicsComponentData Data => data as FrostySdk.Ebx.WaterSurfacePhysicsComponentData;
    public override string DisplayName => "WaterSurfacePhysicsComponent";

    public WaterSurfacePhysicsComponent(FrostySdk.Ebx.WaterSurfacePhysicsComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}



namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DroppedItemPhysicsComponentData))]
public class DroppedItemPhysicsComponent : GamePhysicsComponent, IEntityData<FrostySdk.Ebx.DroppedItemPhysicsComponentData>
{
    public new FrostySdk.Ebx.DroppedItemPhysicsComponentData Data => data as FrostySdk.Ebx.DroppedItemPhysicsComponentData;
    public override string DisplayName => "DroppedItemPhysicsComponent";

    public DroppedItemPhysicsComponent(FrostySdk.Ebx.DroppedItemPhysicsComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


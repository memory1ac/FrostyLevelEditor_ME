
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSoldierPhysicsComponentData))]
public class BFSoldierPhysicsComponent : SoldierPhysicsComponent, IEntityData<FrostySdk.Ebx.BFSoldierPhysicsComponentData>
{
    public new FrostySdk.Ebx.BFSoldierPhysicsComponentData Data => data as FrostySdk.Ebx.BFSoldierPhysicsComponentData;
    public override string DisplayName => "BFSoldierPhysicsComponent";

    public BFSoldierPhysicsComponent(FrostySdk.Ebx.BFSoldierPhysicsComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


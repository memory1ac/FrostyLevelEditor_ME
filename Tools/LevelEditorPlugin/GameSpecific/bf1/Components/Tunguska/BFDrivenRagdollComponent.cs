
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFDrivenRagdollComponentData))]
public class BFDrivenRagdollComponent : EACharacterPhysicsComponent, IEntityData<FrostySdk.Ebx.BFDrivenRagdollComponentData>
{
    public new FrostySdk.Ebx.BFDrivenRagdollComponentData Data => data as FrostySdk.Ebx.BFDrivenRagdollComponentData;
    public override string DisplayName => "BFDrivenRagdollComponent";

    public BFDrivenRagdollComponent(FrostySdk.Ebx.BFDrivenRagdollComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


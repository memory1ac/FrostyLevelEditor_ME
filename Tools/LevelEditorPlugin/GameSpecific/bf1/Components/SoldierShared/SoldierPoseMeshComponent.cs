
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierPoseMeshComponentData))]
public class SoldierPoseMeshComponent : GameComponent, IEntityData<FrostySdk.Ebx.SoldierPoseMeshComponentData>
{
    public new FrostySdk.Ebx.SoldierPoseMeshComponentData Data => data as FrostySdk.Ebx.SoldierPoseMeshComponentData;
    public override string DisplayName => "SoldierPoseMeshComponent";

    public SoldierPoseMeshComponent(FrostySdk.Ebx.SoldierPoseMeshComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


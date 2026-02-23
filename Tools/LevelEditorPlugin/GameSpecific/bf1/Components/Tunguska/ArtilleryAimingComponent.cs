
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ArtilleryAimingComponentData))]
public class ArtilleryAimingComponent : GameComponent, IEntityData<FrostySdk.Ebx.ArtilleryAimingComponentData>
{
    public new FrostySdk.Ebx.ArtilleryAimingComponentData Data => data as FrostySdk.Ebx.ArtilleryAimingComponentData;
    public override string DisplayName => "ArtilleryAimingComponent";

    public ArtilleryAimingComponent(FrostySdk.Ebx.ArtilleryAimingComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


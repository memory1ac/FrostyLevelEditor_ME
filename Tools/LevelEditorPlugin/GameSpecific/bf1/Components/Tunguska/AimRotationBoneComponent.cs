
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AimRotationBoneComponentData))]
public class AimRotationBoneComponent : GameComponent, IEntityData<FrostySdk.Ebx.AimRotationBoneComponentData>
{
    public new FrostySdk.Ebx.AimRotationBoneComponentData Data => data as FrostySdk.Ebx.AimRotationBoneComponentData;
    public override string DisplayName => "AimRotationBoneComponent";

    public AimRotationBoneComponent(FrostySdk.Ebx.AimRotationBoneComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


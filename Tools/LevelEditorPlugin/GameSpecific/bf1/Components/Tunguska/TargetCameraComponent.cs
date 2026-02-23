
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TargetCameraComponentData))]
public class TargetCameraComponent : GameComponent, IEntityData<FrostySdk.Ebx.TargetCameraComponentData>
{
    public new FrostySdk.Ebx.TargetCameraComponentData Data => data as FrostySdk.Ebx.TargetCameraComponentData;
    public override string DisplayName => "TargetCameraComponent";

    public TargetCameraComponent(FrostySdk.Ebx.TargetCameraComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


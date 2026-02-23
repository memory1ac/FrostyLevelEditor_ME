
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TurretRotationSoundComponentData))]
public class TurretRotationSoundComponent : GameComponent, IEntityData<FrostySdk.Ebx.TurretRotationSoundComponentData>
{
    public new FrostySdk.Ebx.TurretRotationSoundComponentData Data => data as FrostySdk.Ebx.TurretRotationSoundComponentData;
    public override string DisplayName => "TurretRotationSoundComponent";

    public TurretRotationSoundComponent(FrostySdk.Ebx.TurretRotationSoundComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


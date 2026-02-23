namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CameraInertiaFloatEntityData))]
public class CameraInertiaFloatEntity : CameraTransformerEntity, IEntityData<FrostySdk.Ebx.CameraInertiaFloatEntityData>
{
    public new FrostySdk.Ebx.CameraInertiaFloatEntityData Data => data as FrostySdk.Ebx.CameraInertiaFloatEntityData;
    public override string DisplayName => "CameraInertiaFloat";

    public CameraInertiaFloatEntity(FrostySdk.Ebx.CameraInertiaFloatEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


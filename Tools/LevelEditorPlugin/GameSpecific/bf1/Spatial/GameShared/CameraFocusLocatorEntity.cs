namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CameraFocusLocatorEntityData))]
public class CameraFocusLocatorEntity : LocatorEntity, IEntityData<FrostySdk.Ebx.CameraFocusLocatorEntityData>
{
    public new FrostySdk.Ebx.CameraFocusLocatorEntityData Data => data as FrostySdk.Ebx.CameraFocusLocatorEntityData;
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public CameraFocusLocatorEntity(FrostySdk.Ebx.CameraFocusLocatorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


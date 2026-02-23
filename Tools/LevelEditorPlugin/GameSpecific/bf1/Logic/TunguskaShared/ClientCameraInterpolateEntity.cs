namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientCameraInterpolateEntityData))]
public class ClientCameraInterpolateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientCameraInterpolateEntityData>
{
    public new FrostySdk.Ebx.ClientCameraInterpolateEntityData Data => data as FrostySdk.Ebx.ClientCameraInterpolateEntityData;
    public override string DisplayName => "ClientCameraInterpolate";

    public ClientCameraInterpolateEntity(FrostySdk.Ebx.ClientCameraInterpolateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


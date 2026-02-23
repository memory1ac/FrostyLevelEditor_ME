namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetSpectatorCameraListEntityData))]
public class BFUIGetSpectatorCameraListEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetSpectatorCameraListEntityData>
{
    public new FrostySdk.Ebx.BFUIGetSpectatorCameraListEntityData Data => data as FrostySdk.Ebx.BFUIGetSpectatorCameraListEntityData;
    public override string DisplayName => "BFUIGetSpectatorCameraList";

    public BFUIGetSpectatorCameraListEntity(FrostySdk.Ebx.BFUIGetSpectatorCameraListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


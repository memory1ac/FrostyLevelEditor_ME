namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetCapturePointSpawnPointEntityData))]
public class BFUIGetCapturePointSpawnPointEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetCapturePointSpawnPointEntityData>
{
    public new FrostySdk.Ebx.BFUIGetCapturePointSpawnPointEntityData Data => data as FrostySdk.Ebx.BFUIGetCapturePointSpawnPointEntityData;
    public override string DisplayName => "BFUIGetCapturePointSpawnPoint";

    public BFUIGetCapturePointSpawnPointEntity(FrostySdk.Ebx.BFUIGetCapturePointSpawnPointEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


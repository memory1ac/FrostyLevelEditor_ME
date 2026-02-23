namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientLoadingMusicEntityData))]
public class ClientLoadingMusicEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientLoadingMusicEntityData>
{
    public new FrostySdk.Ebx.ClientLoadingMusicEntityData Data => data as FrostySdk.Ebx.ClientLoadingMusicEntityData;
    public override string DisplayName => "ClientLoadingMusic";

    public ClientLoadingMusicEntity(FrostySdk.Ebx.ClientLoadingMusicEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


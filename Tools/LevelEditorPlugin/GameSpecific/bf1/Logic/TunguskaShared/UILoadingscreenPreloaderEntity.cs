namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILoadingscreenPreloaderEntityData))]
public class UILoadingscreenPreloaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILoadingscreenPreloaderEntityData>
{
    public new FrostySdk.Ebx.UILoadingscreenPreloaderEntityData Data => data as FrostySdk.Ebx.UILoadingscreenPreloaderEntityData;
    public override string DisplayName => "UILoadingscreenPreloader";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UILoadingscreenPreloaderEntity(FrostySdk.Ebx.UILoadingscreenPreloaderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


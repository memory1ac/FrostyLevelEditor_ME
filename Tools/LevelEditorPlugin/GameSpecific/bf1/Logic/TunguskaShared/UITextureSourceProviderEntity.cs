namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UITextureSourceProviderEntityData))]
public class UITextureSourceProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UITextureSourceProviderEntityData>
{
    public new FrostySdk.Ebx.UITextureSourceProviderEntityData Data => data as FrostySdk.Ebx.UITextureSourceProviderEntityData;
    public override string DisplayName => "UITextureSourceProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UITextureSourceProviderEntity(FrostySdk.Ebx.UITextureSourceProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


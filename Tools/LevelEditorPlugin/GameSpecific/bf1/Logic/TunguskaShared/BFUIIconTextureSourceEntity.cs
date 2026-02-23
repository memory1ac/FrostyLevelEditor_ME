namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIIconTextureSourceEntityData))]
public class BFUIIconTextureSourceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIIconTextureSourceEntityData>
{
    public new FrostySdk.Ebx.BFUIIconTextureSourceEntityData Data => data as FrostySdk.Ebx.BFUIIconTextureSourceEntityData;
    public override string DisplayName => "BFUIIconTextureSource";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIIconTextureSourceEntity(FrostySdk.Ebx.BFUIIconTextureSourceEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


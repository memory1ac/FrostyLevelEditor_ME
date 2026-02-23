namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIButtonTextureSourceEntityData))]
public class BFUIButtonTextureSourceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIButtonTextureSourceEntityData>
{
    public new FrostySdk.Ebx.BFUIButtonTextureSourceEntityData Data => data as FrostySdk.Ebx.BFUIButtonTextureSourceEntityData;
    public override string DisplayName => "BFUIButtonTextureSource";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIButtonTextureSourceEntity(FrostySdk.Ebx.BFUIButtonTextureSourceEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


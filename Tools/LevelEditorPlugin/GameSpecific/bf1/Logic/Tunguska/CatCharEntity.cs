namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CatCharEntityData))]
public class CatCharEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CatCharEntityData>
{
    public new FrostySdk.Ebx.CatCharEntityData Data => data as FrostySdk.Ebx.CatCharEntityData;
    public override string DisplayName => "CatChar";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public CatCharEntity(FrostySdk.Ebx.CatCharEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


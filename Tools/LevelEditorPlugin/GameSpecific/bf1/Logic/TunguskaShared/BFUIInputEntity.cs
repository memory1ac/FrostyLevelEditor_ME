namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIInputEntityData))]
public class BFUIInputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIInputEntityData>
{
    public new FrostySdk.Ebx.BFUIInputEntityData Data => data as FrostySdk.Ebx.BFUIInputEntityData;
    public override string DisplayName => "BFUIInput";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIInputEntity(FrostySdk.Ebx.BFUIInputEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


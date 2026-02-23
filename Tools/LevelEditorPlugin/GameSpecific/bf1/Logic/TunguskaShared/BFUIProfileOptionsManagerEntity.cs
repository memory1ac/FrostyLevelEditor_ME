namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionsManagerEntityData))]
public class BFUIProfileOptionsManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionsManagerEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionsManagerEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionsManagerEntityData;
    public override string DisplayName => "BFUIProfileOptionsManager";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionsManagerEntity(FrostySdk.Ebx.BFUIProfileOptionsManagerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


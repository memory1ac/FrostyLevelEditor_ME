namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIResetProfileOptionsEntityData))]
public class BFUIResetProfileOptionsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIResetProfileOptionsEntityData>
{
    public new FrostySdk.Ebx.BFUIResetProfileOptionsEntityData Data => data as FrostySdk.Ebx.BFUIResetProfileOptionsEntityData;
    public override string DisplayName => "BFUIResetProfileOptions";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIResetProfileOptionsEntity(FrostySdk.Ebx.BFUIResetProfileOptionsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


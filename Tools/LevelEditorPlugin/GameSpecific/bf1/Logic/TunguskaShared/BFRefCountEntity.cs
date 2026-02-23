namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFRefCountEntityData))]
public class BFRefCountEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFRefCountEntityData>
{
    public new FrostySdk.Ebx.BFRefCountEntityData Data => data as FrostySdk.Ebx.BFRefCountEntityData;
    public override string DisplayName => "BFRefCount";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFRefCountEntity(FrostySdk.Ebx.BFRefCountEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


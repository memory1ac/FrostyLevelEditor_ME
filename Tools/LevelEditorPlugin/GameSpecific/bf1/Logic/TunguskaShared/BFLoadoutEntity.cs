namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFLoadoutEntityData))]
public class BFLoadoutEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFLoadoutEntityData>
{
    public new FrostySdk.Ebx.BFLoadoutEntityData Data => data as FrostySdk.Ebx.BFLoadoutEntityData;
    public override string DisplayName => "BFLoadout";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFLoadoutEntity(FrostySdk.Ebx.BFLoadoutEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


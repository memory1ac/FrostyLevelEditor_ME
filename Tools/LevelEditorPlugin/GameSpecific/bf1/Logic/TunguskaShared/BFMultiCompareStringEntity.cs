namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFMultiCompareStringEntityData))]
public class BFMultiCompareStringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFMultiCompareStringEntityData>
{
    public new FrostySdk.Ebx.BFMultiCompareStringEntityData Data => data as FrostySdk.Ebx.BFMultiCompareStringEntityData;
    public override string DisplayName => "BFMultiCompareString";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFMultiCompareStringEntity(FrostySdk.Ebx.BFMultiCompareStringEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


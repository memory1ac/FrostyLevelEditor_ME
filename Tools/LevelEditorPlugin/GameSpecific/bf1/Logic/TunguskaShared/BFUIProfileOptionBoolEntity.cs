namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionBoolEntityData))]
public class BFUIProfileOptionBoolEntity : BFUIProfileOptionEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionBoolEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionBoolEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionBoolEntityData;
    public override string DisplayName => "BFUIProfileOptionBool";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionBoolEntity(FrostySdk.Ebx.BFUIProfileOptionBoolEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


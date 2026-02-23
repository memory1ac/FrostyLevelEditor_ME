namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionEnumEntityData))]
public class BFUIProfileOptionEnumEntity : BFUIProfileOptionEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionEnumEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionEnumEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionEnumEntityData;
    public override string DisplayName => "BFUIProfileOptionEnum";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionEnumEntity(FrostySdk.Ebx.BFUIProfileOptionEnumEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


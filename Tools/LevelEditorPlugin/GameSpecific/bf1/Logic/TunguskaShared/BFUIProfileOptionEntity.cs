namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionEntityData))]
public class BFUIProfileOptionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionEntityData;
    public override string DisplayName => "BFUIProfileOption";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionEntity(FrostySdk.Ebx.BFUIProfileOptionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


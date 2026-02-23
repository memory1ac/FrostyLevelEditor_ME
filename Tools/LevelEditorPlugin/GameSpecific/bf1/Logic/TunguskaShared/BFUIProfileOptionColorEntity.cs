namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionColorEntityData))]
public class BFUIProfileOptionColorEntity : BFUIProfileOptionEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionColorEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionColorEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionColorEntityData;
    public override string DisplayName => "BFUIProfileOptionColor";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionColorEntity(FrostySdk.Ebx.BFUIProfileOptionColorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


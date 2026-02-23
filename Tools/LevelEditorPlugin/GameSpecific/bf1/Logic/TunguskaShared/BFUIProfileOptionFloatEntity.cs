namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionFloatEntityData))]
public class BFUIProfileOptionFloatEntity : BFUIProfileOptionEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionFloatEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionFloatEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionFloatEntityData;
    public override string DisplayName => "BFUIProfileOptionFloat";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionFloatEntity(FrostySdk.Ebx.BFUIProfileOptionFloatEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


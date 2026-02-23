namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionColorStringToVec4EntityData))]
public class BFUIProfileOptionColorStringToVec4Entity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionColorStringToVec4EntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionColorStringToVec4EntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionColorStringToVec4EntityData;
    public override string DisplayName => "BFUIProfileOptionColorStringToVec4";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionColorStringToVec4Entity(FrostySdk.Ebx.BFUIProfileOptionColorStringToVec4EntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


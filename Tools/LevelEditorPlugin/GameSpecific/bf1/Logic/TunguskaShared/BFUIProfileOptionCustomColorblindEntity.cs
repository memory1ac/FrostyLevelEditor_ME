namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionCustomColorblindEntityData))]
public class BFUIProfileOptionCustomColorblindEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionCustomColorblindEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionCustomColorblindEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionCustomColorblindEntityData;
    public override string DisplayName => "BFUIProfileOptionCustomColorblind";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionCustomColorblindEntity(FrostySdk.Ebx.BFUIProfileOptionCustomColorblindEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


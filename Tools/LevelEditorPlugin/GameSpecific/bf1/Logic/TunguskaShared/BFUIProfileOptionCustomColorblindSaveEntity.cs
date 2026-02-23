namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionCustomColorblindSaveEntityData))]
public class BFUIProfileOptionCustomColorblindSaveEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionCustomColorblindSaveEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionCustomColorblindSaveEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionCustomColorblindSaveEntityData;
    public override string DisplayName => "BFUIProfileOptionCustomColorblindSave";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionCustomColorblindSaveEntity(FrostySdk.Ebx.BFUIProfileOptionCustomColorblindSaveEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


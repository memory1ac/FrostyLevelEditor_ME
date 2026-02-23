namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UINPXPersistenceData))]
public class UINPXPersistence : LogicEntity, IEntityData<FrostySdk.Ebx.UINPXPersistenceData>
{
    public new FrostySdk.Ebx.UINPXPersistenceData Data => data as FrostySdk.Ebx.UINPXPersistenceData;
    public override string DisplayName => "UINPXPersistence";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UINPXPersistence(FrostySdk.Ebx.UINPXPersistenceData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


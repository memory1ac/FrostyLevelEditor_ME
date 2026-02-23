namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetUnlockMetaDataEntityData))]
public class BFUIGetUnlockMetaDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetUnlockMetaDataEntityData>
{
    public new FrostySdk.Ebx.BFUIGetUnlockMetaDataEntityData Data => data as FrostySdk.Ebx.BFUIGetUnlockMetaDataEntityData;
    public override string DisplayName => "BFUIGetUnlockMetaData";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIGetUnlockMetaDataEntity(FrostySdk.Ebx.BFUIGetUnlockMetaDataEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


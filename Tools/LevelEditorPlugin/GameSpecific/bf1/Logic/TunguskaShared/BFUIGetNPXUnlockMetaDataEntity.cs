namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetNPXUnlockMetaDataEntityData))]
public class BFUIGetNPXUnlockMetaDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetNPXUnlockMetaDataEntityData>
{
    public new FrostySdk.Ebx.BFUIGetNPXUnlockMetaDataEntityData Data => data as FrostySdk.Ebx.BFUIGetNPXUnlockMetaDataEntityData;
    public override string DisplayName => "BFUIGetNPXUnlockMetaData";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIGetNPXUnlockMetaDataEntity(FrostySdk.Ebx.BFUIGetNPXUnlockMetaDataEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


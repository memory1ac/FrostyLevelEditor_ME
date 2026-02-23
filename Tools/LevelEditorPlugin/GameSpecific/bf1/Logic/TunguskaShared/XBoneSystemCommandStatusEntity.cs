namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.XBoneSystemCommandStatusEntityData))]
public class XBoneSystemCommandStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.XBoneSystemCommandStatusEntityData>
{
    public new FrostySdk.Ebx.XBoneSystemCommandStatusEntityData Data => data as FrostySdk.Ebx.XBoneSystemCommandStatusEntityData;
    public override string DisplayName => "XBoneSystemCommandStatus";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public XBoneSystemCommandStatusEntity(FrostySdk.Ebx.XBoneSystemCommandStatusEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


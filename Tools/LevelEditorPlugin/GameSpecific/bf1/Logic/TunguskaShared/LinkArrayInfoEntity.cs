namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LinkArrayInfoEntityData))]
public class LinkArrayInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LinkArrayInfoEntityData>
{
    public new FrostySdk.Ebx.LinkArrayInfoEntityData Data => data as FrostySdk.Ebx.LinkArrayInfoEntityData;
    public override string DisplayName => "LinkArrayInfo";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public LinkArrayInfoEntity(FrostySdk.Ebx.LinkArrayInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


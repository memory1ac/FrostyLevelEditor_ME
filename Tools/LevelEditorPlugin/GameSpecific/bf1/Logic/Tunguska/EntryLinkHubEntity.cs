namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.EntryLinkHubEntityData))]
public class EntryLinkHubEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EntryLinkHubEntityData>
{
    public new FrostySdk.Ebx.EntryLinkHubEntityData Data => data as FrostySdk.Ebx.EntryLinkHubEntityData;
    public override string DisplayName => "EntryLinkHub";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public EntryLinkHubEntity(FrostySdk.Ebx.EntryLinkHubEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


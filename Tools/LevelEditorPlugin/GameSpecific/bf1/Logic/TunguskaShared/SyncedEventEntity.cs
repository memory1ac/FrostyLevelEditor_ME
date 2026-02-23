namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SyncedEventEntityData))]
public class SyncedEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SyncedEventEntityData>
{
    public new FrostySdk.Ebx.SyncedEventEntityData Data => data as FrostySdk.Ebx.SyncedEventEntityData;
    public override string DisplayName => "SyncedEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SyncedEventEntity(FrostySdk.Ebx.SyncedEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


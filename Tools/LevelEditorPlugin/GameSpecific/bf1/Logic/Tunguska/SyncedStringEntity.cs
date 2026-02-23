namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SyncedStringEntityData))]
public class SyncedStringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SyncedStringEntityData>
{
    public new FrostySdk.Ebx.SyncedStringEntityData Data => data as FrostySdk.Ebx.SyncedStringEntityData;
    public override string DisplayName => "SyncedString";

    public SyncedStringEntity(FrostySdk.Ebx.SyncedStringEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


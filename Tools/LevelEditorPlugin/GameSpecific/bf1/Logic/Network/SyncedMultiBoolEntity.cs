namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SyncedMultiBoolEntityData))]
public class SyncedMultiBoolEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SyncedMultiBoolEntityData>
{
    public new FrostySdk.Ebx.SyncedMultiBoolEntityData Data => data as FrostySdk.Ebx.SyncedMultiBoolEntityData;
    public override string DisplayName => "SyncedMultiBool";

    public SyncedMultiBoolEntity(FrostySdk.Ebx.SyncedMultiBoolEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFRefCountAcquireReleaseEntityData))]
public class BFRefCountAcquireReleaseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFRefCountAcquireReleaseEntityData>
{
    public new FrostySdk.Ebx.BFRefCountAcquireReleaseEntityData Data => data as FrostySdk.Ebx.BFRefCountAcquireReleaseEntityData;
    public override string DisplayName => "BFRefCountAcquireRelease";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFRefCountAcquireReleaseEntity(FrostySdk.Ebx.BFRefCountAcquireReleaseEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


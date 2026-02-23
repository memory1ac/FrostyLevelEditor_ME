namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFRealtimeDelayEntityData))]
public class BFRealtimeDelayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFRealtimeDelayEntityData>
{
    public new FrostySdk.Ebx.BFRealtimeDelayEntityData Data => data as FrostySdk.Ebx.BFRealtimeDelayEntityData;
    public override string DisplayName => "BFRealtimeDelay";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFRealtimeDelayEntity(FrostySdk.Ebx.BFRealtimeDelayEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


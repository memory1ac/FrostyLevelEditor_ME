namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerPingEntityData))]
public class BFUIPlayerPingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerPingEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerPingEntityData Data => data as FrostySdk.Ebx.BFUIPlayerPingEntityData;
    public override string DisplayName => "BFUIPlayerPing";

    public BFUIPlayerPingEntity(FrostySdk.Ebx.BFUIPlayerPingEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


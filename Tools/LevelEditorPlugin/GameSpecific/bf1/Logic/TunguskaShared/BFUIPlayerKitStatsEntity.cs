namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerKitStatsEntityData))]
public class BFUIPlayerKitStatsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerKitStatsEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerKitStatsEntityData Data => data as FrostySdk.Ebx.BFUIPlayerKitStatsEntityData;
    public override string DisplayName => "BFUIPlayerKitStats";

    public BFUIPlayerKitStatsEntity(FrostySdk.Ebx.BFUIPlayerKitStatsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


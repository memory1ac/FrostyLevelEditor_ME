namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpottingPlayerEntityData))]
public class SpottingPlayerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpottingPlayerEntityData>
{
    public new FrostySdk.Ebx.SpottingPlayerEntityData Data => data as FrostySdk.Ebx.SpottingPlayerEntityData;
    public override string DisplayName => "SpottingPlayer";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SpottingPlayerEntity(FrostySdk.Ebx.SpottingPlayerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


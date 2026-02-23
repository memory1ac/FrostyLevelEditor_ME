namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISquadBoostEntityData))]
public class BFUISquadBoostEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISquadBoostEntityData>
{
    public new FrostySdk.Ebx.BFUISquadBoostEntityData Data => data as FrostySdk.Ebx.BFUISquadBoostEntityData;
    public override string DisplayName => "BFUISquadBoost";

    public BFUISquadBoostEntity(FrostySdk.Ebx.BFUISquadBoostEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerBoostEntityData))]
public class BFUIPlayerBoostEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerBoostEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerBoostEntityData Data => data as FrostySdk.Ebx.BFUIPlayerBoostEntityData;
    public override string DisplayName => "BFUIPlayerBoost";

    public BFUIPlayerBoostEntity(FrostySdk.Ebx.BFUIPlayerBoostEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


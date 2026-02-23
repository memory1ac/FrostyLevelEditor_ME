namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.HitTypeCompareEntityData))]
public class HitTypeCompareEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HitTypeCompareEntityData>
{
    public new FrostySdk.Ebx.HitTypeCompareEntityData Data => data as FrostySdk.Ebx.HitTypeCompareEntityData;
    public override string DisplayName => "HitTypeCompare";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public HitTypeCompareEntity(FrostySdk.Ebx.HitTypeCompareEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


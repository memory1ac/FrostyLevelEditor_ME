namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DamageTypeCompareEntityData))]
public class DamageTypeCompareEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DamageTypeCompareEntityData>
{
    public new FrostySdk.Ebx.DamageTypeCompareEntityData Data => data as FrostySdk.Ebx.DamageTypeCompareEntityData;
    public override string DisplayName => "DamageTypeCompare";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public DamageTypeCompareEntity(FrostySdk.Ebx.DamageTypeCompareEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


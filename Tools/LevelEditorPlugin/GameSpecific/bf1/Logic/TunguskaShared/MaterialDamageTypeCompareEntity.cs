namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MaterialDamageTypeCompareEntityData))]
public class MaterialDamageTypeCompareEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MaterialDamageTypeCompareEntityData>
{
    public new FrostySdk.Ebx.MaterialDamageTypeCompareEntityData Data => data as FrostySdk.Ebx.MaterialDamageTypeCompareEntityData;
    public override string DisplayName => "MaterialDamageTypeCompare";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public MaterialDamageTypeCompareEntity(FrostySdk.Ebx.MaterialDamageTypeCompareEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


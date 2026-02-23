namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FloatRangeConverterEntityData))]
public class FloatRangeConverterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FloatRangeConverterEntityData>
{
    public new FrostySdk.Ebx.FloatRangeConverterEntityData Data => data as FrostySdk.Ebx.FloatRangeConverterEntityData;
    public override string DisplayName => "FloatRangeConverter";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FloatRangeConverterEntity(FrostySdk.Ebx.FloatRangeConverterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


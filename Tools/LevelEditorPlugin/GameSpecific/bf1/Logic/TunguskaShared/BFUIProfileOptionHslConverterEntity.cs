namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionHslConverterEntityData))]
public class BFUIProfileOptionHslConverterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionHslConverterEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionHslConverterEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionHslConverterEntityData;
    public override string DisplayName => "BFUIProfileOptionHslConverter";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionHslConverterEntity(FrostySdk.Ebx.BFUIProfileOptionHslConverterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


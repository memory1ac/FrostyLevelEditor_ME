namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AngleDamageEntityData))]
public class AngleDamageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AngleDamageEntityData>
{
    public new FrostySdk.Ebx.AngleDamageEntityData Data => data as FrostySdk.Ebx.AngleDamageEntityData;
    public override string DisplayName => "AngleDamage";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public AngleDamageEntity(FrostySdk.Ebx.AngleDamageEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


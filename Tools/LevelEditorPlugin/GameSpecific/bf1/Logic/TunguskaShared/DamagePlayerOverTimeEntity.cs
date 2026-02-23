namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DamagePlayerOverTimeEntityData))]
public class DamagePlayerOverTimeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DamagePlayerOverTimeEntityData>
{
    public new FrostySdk.Ebx.DamagePlayerOverTimeEntityData Data => data as FrostySdk.Ebx.DamagePlayerOverTimeEntityData;
    public override string DisplayName => "DamagePlayerOverTime";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public DamagePlayerOverTimeEntity(FrostySdk.Ebx.DamagePlayerOverTimeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


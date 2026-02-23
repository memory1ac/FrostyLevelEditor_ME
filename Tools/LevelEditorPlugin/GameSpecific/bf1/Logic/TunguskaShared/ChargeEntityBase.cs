namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ChargeEntityBaseData))]
public class ChargeEntityBase : LogicEntity, IEntityData<FrostySdk.Ebx.ChargeEntityBaseData>
{
    public new FrostySdk.Ebx.ChargeEntityBaseData Data => data as FrostySdk.Ebx.ChargeEntityBaseData;
    public override string DisplayName => "ChargeEntityBase";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ChargeEntityBase(FrostySdk.Ebx.ChargeEntityBaseData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


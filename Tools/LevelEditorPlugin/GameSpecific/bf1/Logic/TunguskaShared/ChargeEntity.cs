namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ChargeEntityData))]
public class ChargeEntity : ChargeEntityBase, IEntityData<FrostySdk.Ebx.ChargeEntityData>
{
    public new FrostySdk.Ebx.ChargeEntityData Data => data as FrostySdk.Ebx.ChargeEntityData;
    public override string DisplayName => "Charge";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ChargeEntity(FrostySdk.Ebx.ChargeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


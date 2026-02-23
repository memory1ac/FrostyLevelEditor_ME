namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.HorseChargeEntityData))]
public class HorseChargeEntity : ChargeEntityBase, IEntityData<FrostySdk.Ebx.HorseChargeEntityData>
{
    public new FrostySdk.Ebx.HorseChargeEntityData Data => data as FrostySdk.Ebx.HorseChargeEntityData;
    public override string DisplayName => "HorseCharge";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public HorseChargeEntity(FrostySdk.Ebx.HorseChargeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


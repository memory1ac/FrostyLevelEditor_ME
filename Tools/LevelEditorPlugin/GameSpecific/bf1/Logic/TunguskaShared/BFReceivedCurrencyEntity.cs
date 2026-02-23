namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFReceivedCurrencyEntityData))]
public class BFReceivedCurrencyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFReceivedCurrencyEntityData>
{
    public new FrostySdk.Ebx.BFReceivedCurrencyEntityData Data => data as FrostySdk.Ebx.BFReceivedCurrencyEntityData;
    public override string DisplayName => "BFReceivedCurrency";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFReceivedCurrencyEntity(FrostySdk.Ebx.BFReceivedCurrencyEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


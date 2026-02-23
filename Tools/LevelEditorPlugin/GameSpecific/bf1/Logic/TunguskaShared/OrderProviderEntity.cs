namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.OrderProviderEntityData))]
public class OrderProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.OrderProviderEntityData>
{
    public new FrostySdk.Ebx.OrderProviderEntityData Data => data as FrostySdk.Ebx.OrderProviderEntityData;
    public override string DisplayName => "OrderProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public OrderProviderEntity(FrostySdk.Ebx.OrderProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


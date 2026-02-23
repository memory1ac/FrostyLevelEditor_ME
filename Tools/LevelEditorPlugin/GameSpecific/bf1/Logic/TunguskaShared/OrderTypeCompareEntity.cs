namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.OrderTypeCompareEntityData))]
public class OrderTypeCompareEntity : LogicEntity, IEntityData<FrostySdk.Ebx.OrderTypeCompareEntityData>
{
    public new FrostySdk.Ebx.OrderTypeCompareEntityData Data => data as FrostySdk.Ebx.OrderTypeCompareEntityData;
    public override string DisplayName => "OrderTypeCompare";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public OrderTypeCompareEntity(FrostySdk.Ebx.OrderTypeCompareEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.OrderActionData))]
public class OrderAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.OrderActionData>
{
    public new FrostySdk.Ebx.OrderActionData Data => data as FrostySdk.Ebx.OrderActionData;
    public override string DisplayName => "OrderAction";

    public OrderAction(FrostySdk.Ebx.OrderActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


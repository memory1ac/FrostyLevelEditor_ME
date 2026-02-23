namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIRibbonReceivedEntityData))]
public class BFUIRibbonReceivedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIRibbonReceivedEntityData>
{
    public new FrostySdk.Ebx.BFUIRibbonReceivedEntityData Data => data as FrostySdk.Ebx.BFUIRibbonReceivedEntityData;
    public override string DisplayName => "BFUIRibbonReceived";

    public BFUIRibbonReceivedEntity(FrostySdk.Ebx.BFUIRibbonReceivedEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISPAwardReceivedEntityData))]
public class BFUISPAwardReceivedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISPAwardReceivedEntityData>
{
    public new FrostySdk.Ebx.BFUISPAwardReceivedEntityData Data => data as FrostySdk.Ebx.BFUISPAwardReceivedEntityData;
    public override string DisplayName => "BFUISPAwardReceived";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUISPAwardReceivedEntity(FrostySdk.Ebx.BFUISPAwardReceivedEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


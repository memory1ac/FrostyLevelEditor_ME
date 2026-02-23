namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDogTagReceivedEntityData))]
public class UIDogTagReceivedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIDogTagReceivedEntityData>
{
    public new FrostySdk.Ebx.UIDogTagReceivedEntityData Data => data as FrostySdk.Ebx.UIDogTagReceivedEntityData;
    public override string DisplayName => "UIDogTagReceived";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIDogTagReceivedEntity(FrostySdk.Ebx.UIDogTagReceivedEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


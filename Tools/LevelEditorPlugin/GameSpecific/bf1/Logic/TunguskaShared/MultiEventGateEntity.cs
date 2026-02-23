namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MultiEventGateEntityData))]
public class MultiEventGateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MultiEventGateEntityData>
{
    public new FrostySdk.Ebx.MultiEventGateEntityData Data => data as FrostySdk.Ebx.MultiEventGateEntityData;
    public override string DisplayName => "MultiEventGate";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public MultiEventGateEntity(FrostySdk.Ebx.MultiEventGateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}


namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFGetFactionIdEntityData))]
public class BFGetFactionIdEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFGetFactionIdEntityData>
{
    public new FrostySdk.Ebx.BFGetFactionIdEntityData Data => data as FrostySdk.Ebx.BFGetFactionIdEntityData;
    public override string DisplayName => "BFGetFactionId";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFGetFactionIdEntity(FrostySdk.Ebx.BFGetFactionIdEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

